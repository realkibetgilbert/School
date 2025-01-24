using FluentValidation;
using School.API.Dto.Students;

namespace School.API.Utils.Validators
{    public class StudentDtoValidator:AbstractValidator<StudentToCreateDto>
    {
        public StudentDtoValidator()
        {

            RuleFor(s => s.Name)
                .NotEmpty().WithMessage(" weka jinaaaa");
        }
    }
}
