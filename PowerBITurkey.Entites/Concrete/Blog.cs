using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PowerBITurkey.Core.Entites;

namespace PowerBITurkey.Entities.Concrete
{
    public class Blog : IEntity
    {
        [DisplayName("Blog Id")]
        public int BlogId { get; set; }
        [DisplayName("Blog Title")]
        public string BlogTitle { get; set; }

        [DisplayName("Blog Context")]
        public string BlogContext { get; set; }
        
    }
}
