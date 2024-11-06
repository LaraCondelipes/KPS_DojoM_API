using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using Newtonsoft.Json;

namespace KPS_DojoM_models
{
    public class Categories
    {
        public int CategoriesId { get; set; }
        public string? CategoryName { get; set; }

        public decimal? Weight { get; set; }

        public string? Kyu { get; set; }

        [JsonIgnore]
        public virtual List<Events>? Events { get; set; }

        [JsonIgnore]
        public virtual List<TheResults>? TheResults { get; set; }

    }
}
