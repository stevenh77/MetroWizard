using System;
using FluentValidation;
using MetroWizard.Models;

namespace MetroWizard.Validators
{
    public class IdentifiersModelValidator : AbstractValidator<IdentifiersModel>
    {
        public IdentifiersModelValidator()
        {
            RuleFor(x => x.ISIN)
                .Length(6)
                .WithMessage("Must be 6 alphanumeric characters.");

            RuleFor(x => x.MIC)
                .Length(4, 8)
                .WithMessage("Must be between 4 and 8 alphanumeric characters.");

            RuleFor(x => x.SIC)
                .Matches(@"^\d{5}$")
                .WithMessage("Must be 5 numeric characters" + 
                              Environment.NewLine +
                              "(example of a RegEx).");
        }
    }
}