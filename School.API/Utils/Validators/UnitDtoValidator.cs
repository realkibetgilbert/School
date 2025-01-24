using FluentValidation;
using School.API.Dto.Units;

namespace School.API.Utils.Validators
{
    public class UnitDtoValidator : AbstractValidator<UnitToCreateDto>
    {
        public UnitDtoValidator()
        {
            RuleFor(unit => unit.UnitName)
                .NotEmpty().WithMessage("Unit Name is required")
                .MinimumLength(3).WithMessage("Characters shuold be more than three");
            RuleFor(unit => unit.UnitCode)
               .NotEmpty().WithMessage("Unit Code is required")
               .MinimumLength(3).WithMessage("Characters shuold be more than three");
            RuleFor(unit => unit.Status)
              .NotEmpty();
        }
    }
}
