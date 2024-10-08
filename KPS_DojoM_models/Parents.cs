using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPS_DojoM_models
{
   public class Parents
    {
        public int? Id { get; set; }
        public string? ParentName { get; set; }
        public string? ParentAddress { get; set; }
        public int? ParentCellPhone { get; set; }
        public int? ParentNif { get; set; }
        public int? ParentCcNumber { get; set; }
        public string? ParentEmail { get; set; }
        public int? AthleteId { get; set; }
    }
}
