using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KPS_DojoM_models
{
    public class Events
    {
        public int? Id { get; set; }
        public string? EventName { get; set; }

        [JsonIgnore]
        public virtual List<Categories>? Categories { get; set; }

        public int? ChampionshipId { get; set; }

        [JsonIgnore]
        public virtual Championships? Championships { get; set; }

    }
}
