using PowerBITurkey.Core.DataAccess.EntityFramework;
using PowerBITurkey.DataAccess.Abstract;
using PowerBITurkey.Entities.Concrete;

namespace PowerBITurkey.DataAccess.Concrete.EntityFramework
{
    public class EfPersonalInformationDal: EfEntityRepositoryBase<PersonalInformation,PowerBITurkeyContext>,IPersonalInformationDal
    {
    }
}
