using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerBITurkey.Business.Abstract;
using PowerBITurkey.Business.ValidationRules.FluentValidation;
using PowerBITurkey.Core.CrossCuttingConcers.Aspects.PostSharp;
using PowerBITurkey.DataAccess.Abstract;
using PowerBITurkey.Entities.Concrete;

namespace PowerBITurkey.Business.Concrete
{
    public class PersonalInformationManager :IPersonalInformationService
    {
        private readonly IPersonalInformationDal _personalInformationDal;

        public PersonalInformationManager(IPersonalInformationDal personalInformationDal)
        {
            _personalInformationDal = personalInformationDal;
        }

        public List<PersonalInformation> GetAllInformation()
        {
            return _personalInformationDal.GetAll();
        }

        public PersonalInformation GetPersonalInformation(int aboutId)
        {
            return _personalInformationDal.GetByPattern(p => p.AboutId == aboutId);
        }

        [FluentValidationAspect(typeof(PersonalInformationValidator))]
        public PersonalInformation UpdateInformation(PersonalInformation personalInformation)
        {
            return _personalInformationDal.Update(personalInformation);
        }

        [FluentValidationAspect(typeof(PersonalInformationValidator))]
        public PersonalInformation AddInformation(PersonalInformation personalInformation)
        {
            return _personalInformationDal.Add(personalInformation);
        }


        [FluentValidationAspect(typeof(PersonalInformationValidator))]
        public void DeleteInformation(PersonalInformation personalInformation)
        {
            _personalInformationDal.Delete(personalInformation);
        }
    }
}
