using Microsoft.EntityFrameworkCore;
using Ninject.Modules;
using PowerBITurkey.Business.Abstract;
using PowerBITurkey.Business.Concrete;
using PowerBITurkey.DataAccess.Abstract;
using PowerBITurkey.DataAccess.Concrete.EntityFramework;

namespace PowerBITurkey.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonalInformationDal>().To<EfPersonalInformationDal>().InSingletonScope();
            Bind<IPersonalInformationService>().To<PersonalInformationManager>().InSingletonScope();
            Bind<IBlogService>().To<BlogManager>().InSingletonScope();
            Bind<IBlogDal>().To<EfBlogDal>().InSingletonScope();
            Bind<DbContext>().To<PowerBITurkeyContext>();
        }
    }
}
