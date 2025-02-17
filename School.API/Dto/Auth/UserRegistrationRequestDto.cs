namespace School.API.Dto.Auth
{
    public class UserRegistrationRequestDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; set; }
        public string Password { get; set; }
        public string[] Roles { get; set; }

    }
}
