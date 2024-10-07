using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPS_DojoM_models
{
    internal class Results
    {
        public int ResultId { get; set; }
        public string ResultName { get; set; }
        public int PodiumPlace { get; set; }
        public virtual List<Categories> Category { get; set; }
        public virtual List<Events> Event { get; set; }


    }
}
