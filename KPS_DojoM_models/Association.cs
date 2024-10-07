

namespace KPS_DojoM_models
{
    internal class Association
    {
        public int AssociationId { get; set; }
        public string AssociationName { get; set; }
        public int NemberNumber { get; set; }
        public virtual List<Athletes> Athlete { get; set; }
        public virtual List<Championships> Championship { get; set; }

    }
}
