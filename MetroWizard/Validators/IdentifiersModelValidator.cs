using FluentValidation;
using MetroWizard.Models;

namespace MetroWizard.Validators
{
    public class IdentifiersModelValidator : AbstractValidator<IdentifiersModel>
    {
        public IdentifiersModelValidator()
        {
            RuleFor(x => x.ISIN)
                .Length(3, 8)
                .WithMessage("Must be between 3-8 characters.");

            RuleFor(x => x.MIC)
                .Length(6)
                .WithMessage("Must be 6 characters.");
        }
    }
}
