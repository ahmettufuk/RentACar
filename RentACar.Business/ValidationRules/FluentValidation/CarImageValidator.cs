using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using RentACar.Entities.Concrete;

namespace RentACar.Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(c=> c.Date).NotNull().NotEmpty();
            RuleFor(c => c.Date).NotNull().NotEmpty();
        }
    }
}
