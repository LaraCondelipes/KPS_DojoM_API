using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPS_DojoM_models
{
    internal class Championships
    {
        public int? ChampionshipId { get; set; }
        public int? ChampionshipName { get; set; }
        public int? AssociationId { get; set; }
        public virtual List<Results>? Result { get; set; }
    }
}
