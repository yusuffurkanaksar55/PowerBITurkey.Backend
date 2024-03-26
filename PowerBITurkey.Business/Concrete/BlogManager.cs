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
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogList()
        {
            return _blogDal.GetAll();
        }

        public Blog GetBlog(int blogId)
        {
            return _blogDal.GetByPattern(b => b.BlogId == blogId);
        }

        [FluentValidationAspect(typeof(BlogValidator))]
        public Blog Update(Blog blog)
        {
            return _blogDal.Update(blog);
        }

        [FluentValidationAspect(typeof(BlogValidator))]
        public Blog Add(Blog blog)
        {
            return _blogDal.Add(blog);
        }
        [FluentValidationAspect(typeof(BlogValidator))]
        public void Delete(Blog blog)
        {
            _blogDal.Delete(blog);
        }
    }
}
