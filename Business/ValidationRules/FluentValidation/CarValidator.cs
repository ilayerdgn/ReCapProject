using System;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CDescription).MinimumLength(3);
            RuleFor(c => c.DailyPrice).NotEmpty();
            
        }
    }
}
