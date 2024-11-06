using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KPS_DojoM_models
{
    public class Senseis
    {
        public int? Id { get; set; }
        public string? SeinseiName { get; set; } 
        public int? SenseiKYU { get; set; }
        public int? LicenceNumber { get; set; }
        public int? SenseiCellPhone { get; set; }
        public string? SenseiEmail { get; set; }
        public int AssociationMemberNumber { get; set; }
        public int? AssociationId { get; set; }
        [JsonIgnore]
        public virtual Association? Association { get; set; }

    }
}
