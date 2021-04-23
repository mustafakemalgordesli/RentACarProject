using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(ctr => ctr.UserId).NotEmpty();
            RuleFor(ctr => ctr.CompanyName).NotEmpty();
        }
    }
}
