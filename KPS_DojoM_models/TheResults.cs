
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KPS_DojoM_models
{
    public class TheResults
    {
        public int? Id { get; set; }
        public string? ResultName { get; set; }
        public int? PodiumPlace { get; set; }

        public int? AthletesId { get; set; }
        [JsonIgnore]
        public virtual Athletes? Athletes { get; set; }
        public int? CategoriesId { get; set; }
        [JsonIgnore]
        public virtual Categories? Categories { get; set; }

    }
}
