using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerBITurkey.Core.DataAccess.EntityFramework;
using PowerBITurkey.Entities.Concrete;

namespace PowerBITurkey.DataAccess.Abstract
{
    public interface IBlogDal :IEntityRepositoryBase<Blog>
    {
    }
}
