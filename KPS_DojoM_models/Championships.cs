using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KPS_DojoM_models
{
    public class Championships
    {
        public int? ChampionshipsId { get; set; }
        public string? ChampionshipName { get; set; }
        public int? AssociationId { get; set; }
        [JsonIgnore]
        public virtual Association? Association { get; set; }
        [JsonIgnore]
        public virtual List<Events>? Events { get; set; }
    }
}
