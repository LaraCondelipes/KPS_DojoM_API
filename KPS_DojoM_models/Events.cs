using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPS_DojoM_models
{
    public class Events
    {
        public int? Id { get; set; }
        public string? EventName { get; set; }
     
        public virtual List<Categories>? Category { get; set; } 
    }
}
