using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(s => s.ServiceName).NotEmpty();
            RuleFor(s => s.Price).NotEmpty();
            RuleFor(s => s.Description).NotEmpty();
        }
    }
}
