using FluentValidation;
using School.API.Dto.Hostel;

namespace School.API.Utils.Validators
{
    public class HostelDtoValidator : AbstractValidator<HostelToCreateDto>
    {
        public HostelDtoValidator()
        {
            RuleFor(h => h.Name)
                .NotEmpty().WithMessage("Name is required")
                .MinimumLength(3).WithMessage("Name should be atleast three characters.");
            RuleFor(h => h.Description)
               .NotEmpty().WithMessage("Description is required")
               .MinimumLength(3).WithMessage("Description should be atleast three characters.");
        }
    }
}
