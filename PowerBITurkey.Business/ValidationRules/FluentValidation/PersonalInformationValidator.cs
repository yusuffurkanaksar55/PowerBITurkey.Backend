using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using PowerBITurkey.Entities.Concrete;

namespace PowerBITurkey.Business.ValidationRules.FluentValidation
{
    public class PersonalInformationValidator : AbstractValidator<PersonalInformation>
    {
        public PersonalInformationValidator()
        {
            RuleFor(p=>p.AboutMe).NotEmpty();
            RuleFor(p=>p.Email).NotEmpty();
            RuleFor(p => p.HelloMessage).NotEmpty();
            RuleFor(p=>p.LinkedinURL).NotEmpty();
        }
    }
}
