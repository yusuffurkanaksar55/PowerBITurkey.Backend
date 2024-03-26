using PowerBITurkey.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerBITurkey.Core.DataAccess;
using PowerBITurkey.Core.DataAccess.EntityFramework;

namespace PowerBITurkey.DataAccess.Abstract
{
    public interface IPersonalInformationDal : IEntityRepositoryBase<PersonalInformation>
    {
    }
}
