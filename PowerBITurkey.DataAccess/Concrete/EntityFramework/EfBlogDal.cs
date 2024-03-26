using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerBITurkey.Core.DataAccess.EntityFramework;
using PowerBITurkey.DataAccess.Abstract;
using PowerBITurkey.Entities.Concrete;

namespace PowerBITurkey.DataAccess.Concrete.EntityFramework
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog,PowerBITurkeyContext>, IBlogDal
    {
    }
}
