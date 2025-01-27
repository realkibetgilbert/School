using FluentValidation;
using School.API.Dto.Students;

namespace School.API.Utils.Validators
{    public class StudentDtoValidator:AbstractValidator<StudentToCreateDto>
    {
        public StudentDtoValidator()
        {

            RuleFor(s => s.Name)
                .NotEmpty().WithMessage("weka jinaaaa")
                .MinimumLength(3).WithMessage("Name should be atleast three characters");
            RuleFor(s => s.RegistrationNumber)
                .NotEmpty().WithMessage("Registration Number is required")
                .MinimumLength(3).WithMessage("Registration Number should be atleast three characters");
            RuleFor(s => s.DateOfJoin).NotEmpty();
            RuleFor(s => s.IsActive).NotEmpty();
            RuleFor(s => s.HostelId).NotEmpty();
        }
    }
}
