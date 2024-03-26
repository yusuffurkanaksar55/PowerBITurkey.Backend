using PowerBITurkey.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBITurkey.DataAccess.Concrete.EntityFramework.Mapping
{
    public class BlogMapper : EntityTypeConfiguration<Blog>
    {
        public BlogMapper()
        {
            ToTable(@"Blogs", "dbo");
            HasKey(x => x.BlogId);

            Property(x => x.BlogId).HasColumnName("BlogId");
            Property(x => x.BlogTitle).HasColumnName("BlogTitle");
            Property(x => x.BlogContext).HasColumnName("BlogContext");
        }

    }
}
