using ProjectOshKUU.Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OshKUU.Models
{
    public class Audience:IEntityBase
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string? Name { get; set; }
        public string? InfoAudit { get; set; }
        public string? NumberAudit { get; set; }
        public int Floor { get; set; }
        public string  Lang { get; set; }
        public int  Building { get; set; }
      

    }
}
