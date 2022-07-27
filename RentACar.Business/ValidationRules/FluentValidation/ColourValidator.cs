using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using RentACar.Entities.Concrete;

namespace RentACar.Business.ValidationRules.FluentValidation
{
    public class ColourValidator : AbstractValidator<Color>
    {
        public ColourValidator()
        {
            RuleFor(c => c.ColorName).NotEmpty().NotNull().MinimumLength(2);
        }
    }
}
