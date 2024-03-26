using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Ninject.Modules;
using PowerBITurkey.Business.ValidationRules.FluentValidation;
using PowerBITurkey.Entities.Concrete;

namespace PowerBITurkey.Business.DependencyResolvers.Ninject
{
    public class ValidationModule :NinjectModule
    {
        public override void Load()
        {
            Bind<IValidator<PersonalInformation>>().To<PersonalInformationValidator>().InSingletonScope();
        }
    }
}
