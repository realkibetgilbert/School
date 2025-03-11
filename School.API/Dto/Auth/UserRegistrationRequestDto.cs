namespace School.API.Dto.Auth
{
    public class UserRegistrationRequestDto
    {

        public string Email { get; set; }
        public string Password { get; set; }
        public string[] Roles { get; set; }

    }
}
