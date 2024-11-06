

using Newtonsoft.Json;

namespace KPS_DojoM_models
{
    public class Association
    {
        public int? AssociationId { get; set; }
        public string? AssociationName { get; set; }

        [JsonIgnore]
        public virtual List<Athletes>? Athletes { get; set; }
        [JsonIgnore]
        public virtual List<Championships>? Championships { get; set; }

    }
}
