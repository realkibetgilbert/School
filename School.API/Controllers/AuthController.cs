using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using School.API.Dto.Auth;
using School.MODEL;
using Microsoft.AspNetCore.Identity;

namespace School.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
       
        private readonly UserManager<AuthUser> _userManager;

        public AuthController(UserManager<AuthUser> userManager)
        {
          
            _userManager = userManager;
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
            string userName = "";

            var existingUser = await _userManager.FindByEmailAsync(expressWayPosUserDto.UserName);

            int userCount = _userManager.Users.Count(u => u.Email == expressWayPosUserDto.UserName);

            if (userCount >= 1)
            {
                userName = $"{expressWayPosUserDto.UserName}-{userCount}";
            }

            else
            {
                userName = expressWayPosUserDto.UserName;
            }

            if (existingUser != null && existingUser.IsActive)
            {
                var error = new ErrorMessage
                {
                    title = "Fail",
                    message = "User with the above user name is active"
                };

                return BadRequest(error);

            }
            var user = new AuthUser { UserName = userName, Email = expressWayPosUserDto.UserName, PhoneNumber = expressWayPosUserDto.PhoneNumber, FirstName = expressWayPosUserDto.FirstName, LastName = expressWayPosUserDto.LastName, IsActive = true };

            var result = await _userManager.CreateAsync(user, expressWayPosUserDto.Password);

            if (result.Succeeded)
            {
                if (expressWayPosUserDto.Roles != null && expressWayPosUserDto.Roles.Length > 0)
                {
                    foreach (var roleName in expressWayPosUserDto.Roles)
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

                return BadRequest(result.Errors);
            }
        }


    }
}
