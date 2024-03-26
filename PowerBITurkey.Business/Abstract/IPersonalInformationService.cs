
using PowerBITurkey.Entities.Concrete;

namespace PowerBITurkey.Business.Abstract
{
    public interface IPersonalInformationService
    {
        List<PersonalInformation> GetAllInformation();
        PersonalInformation GetPersonalInformation(int aboutId);
        PersonalInformation UpdateInformation(PersonalInformation personalInformation);
        PersonalInformation AddInformation(PersonalInformation personalInformation);
        void DeleteInformation(PersonalInformation personalInformation);
    }
}
