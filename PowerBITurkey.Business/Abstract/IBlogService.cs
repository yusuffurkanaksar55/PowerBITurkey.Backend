using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerBITurkey.Entities.Concrete;

namespace PowerBITurkey.Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetBlogList();
        Blog GetBlog(int blogId);
        Blog Update(Blog blog);
        Blog Add(Blog blog);
        void Delete(Blog blog);

    }
}
