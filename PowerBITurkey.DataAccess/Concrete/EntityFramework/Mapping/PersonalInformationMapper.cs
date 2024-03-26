using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerBITurkey.Entities.Concrete;

namespace PowerBITurkey.DataAccess.Concrete.EntityFramework.Mapping
{
    public class PersonalInformationMapper :EntityTypeConfiguration<PersonalInformation>
    {
        public PersonalInformationMapper()
        {
            ToTable(@"PersonalInformations", "dbo");
            HasKey(x => x.AboutId);

            Property(x => x.AboutId).HasColumnName("AboutId");
            Property(x => x.AboutMe).HasColumnName("AboutMe");
            Property(x => x.HelloMessage).HasColumnName("HelloMessage");
            Property(x => x.Email).HasColumnName("Email");
            Property(x => x.LinkedinURL).HasColumnName("LinkedinURL");
        }
    }
}
