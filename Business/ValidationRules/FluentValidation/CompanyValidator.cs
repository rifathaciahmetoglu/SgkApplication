using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Name).MinimumLength(1);

            RuleFor(c => c.ShortName).NotEmpty();
            RuleFor(c => c.ShortName).MinimumLength(1);
            RuleFor(c => c.ShortName).MaximumLength(3);
        }
    }
}
