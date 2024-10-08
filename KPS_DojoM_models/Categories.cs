using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPS_DojoM_models
{
    internal class Categories
    {
        public int? CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public virtual List<Athletes>? Athlete { get; set; }
       
        public virtual List<Events>? Event { get; set; }
    }
}
