using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using RentACar.Entities.Concrete;

namespace RentACar.Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty().NotNull().MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty().GreaterThan(0).NotNull();
            RuleFor(c => c.Description).NotEmpty().MaximumLength(550);
        }
    }
}
