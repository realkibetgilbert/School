using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using School.API.Dto.Auth;
using School.API.Interfaces;
using School.MODEL;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly UserManager<AuthUser> _userManager;
        private readonly RoleManager<IdentityRole<long>> _roleManager;
        private readonly ITokenRepository _tokenRepository;

        public AuthController(UserManager<AuthUser> userManager, RoleManager<IdentityRole<long>> roleManager, ITokenRepository tokenRepository)
        {

            _userManager = userManager;
            _roleManager = roleManager;
            _tokenRepository = tokenRepository;
        }

        [HttpPost]
        [Route("Role")]
        public async Task<IActionResult> CreateRole([FromBody] RoleNameDto roleNameDto)
        {

            var role = new IdentityRole<long> { Name = roleNameDto.Name };

            var result = await _roleManager.CreateAsync(role);

            if (result.Succeeded)
            {
                return Ok(new { Name = role.Name });
            }
            else
            {
                return BadRequest(result.Errors);
            }
        }

        [HttpGet]
        [Route("Role")]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return Ok(roles);
        }

        //TODO: ImplementRegister
        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> RegisterUser(UserRegistrationRequestDto userRegistrationDto)
        {

            var existingUser = await _userManager.FindByEmailAsync(userRegistrationDto.Email);


            if (existingUser != null)
            {
                var error = new
                {
                    title = "Fail",
                    message = "User with the above name exists"
                };

                return BadRequest(error);
            }

            var user = new AuthUser { UserName = userRegistrationDto.Email, Email = userRegistrationDto.Email };

            var result = await _userManager.CreateAsync(user, userRegistrationDto.Password);


            if (result.Succeeded)
            {
                if (userRegistrationDto.Roles != null && userRegistrationDto.Roles.Length > 0)
                {
                    foreach (var roleName in userRegistrationDto.Roles)
                    {
                        var existingRole = await _roleManager.FindByNameAsync(roleName);

                        if (existingRole != null)
                        {
                            var addToRoleResult = await _userManager.AddToRoleAsync(user, roleName);

                            if (!addToRoleResult.Succeeded)
                            {
                                await _userManager.DeleteAsync(user);

                                return BadRequest(addToRoleResult.Errors);
                            }
                        }
                    }
                }

                var message = new
                {
                    title = "Success",
                    description = "User Registered successfully with roles"
                };

                return Ok(message);
            }

            else
            {

                return BadRequest("User not registered");
            }
        }

        [HttpPost]

        [Route("Login")]

        public async Task<IActionResult> Login(LoginDto loginDto)

        {

            AuthUser loginUser = await _userManager.Users.FirstOrDefaultAsync(e => e.Email == loginDto.UserName);

            bool checkPasswordResult = await _userManager.CheckPasswordAsync(loginUser, loginDto.Password);

            if (checkPasswordResult)

            {

                var roles = await _userManager.GetRolesAsync(loginUser);

                if (loginUser == null)

                {

                    throw new NullReferenceException("loginUser is null.");

                }

                var jwtToken = _tokenRepository.CreateJwtToken(loginUser, roles.ToList());

                var res = new LoginResponseDto

                {

                    Email = loginDto.UserName,

                    Token = jwtToken,

                    Roles = roles.ToList()

                };

                var jsonRes = JsonConvert.SerializeObject(res);

                return Content(jsonRes, "application/json");

            }

            else

            {

                var error = new

                {

                    title = "Invalid Credentials",

                    message = "The Submitted Login Credentials are Invalid"

                };

                return BadRequest(error);

            }


        }

    }
}