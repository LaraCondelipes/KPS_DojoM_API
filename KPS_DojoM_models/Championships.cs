using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPS_DojoM_models
{
    public class Championships
    {
        public int? ChampionshipId { get; set; }
        public int? ChampionshipName { get; set; }
        public int? AssociationId { get; set; }
        public virtual List<TheResults>? Result { get; set; }
    }
}
