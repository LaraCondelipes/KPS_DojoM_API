

namespace KPS_DojoM_models
{
    public class Association
    {
        public int? Id { get; set; }
        public string? AssociationName { get; set; }
        public virtual List<Athletes>? Athlete { get; set; }
        public virtual List<Championships>? Championships { get; set; }

    }
}
