using PowerBITurkey.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerBITurkey.Entities.Concrete
{
    public class PersonalInformation :IEntity
    {
        public int AboutId { get; set; }
        public string AboutMe { get; set; }
        public string  HelloMessage { get; set; }
        public string Email { get; set; }
        public string LinkedinURL { get; set; }
    }
}
