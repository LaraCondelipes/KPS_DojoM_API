using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace KPS_DojoM_models
{
    public class Athletes
    {
        [Key]
        public int? AthletesId { get; set; }
        public string? AthleteGraduation { get; set; }
        public string? AthleteName { get; set; }

        [DataType(DataType.Date)]  //forces only the date to be rendered
        public DateTime? AthleteBirthdayDate { get; set; } 
        public string? AthleteAddress { get; set; }
        public string? AthleteEmail { get; set; }
        public int? AthleteCellPhone { get; set; }
        public int? AthleteNif { get; set; }
        public int? AthleteCcNumber { get; set; }
        public string? Club { get; set; }
        public int? AthleteClubMemberNumber { get; set; }
        public int? AssociationMemberNumber { get; set; }

        [ForeignKey("AssociationId")]
        public int? AssociationId { get; set; }
        [JsonIgnore]
        public virtual Association? Association { get; set; }
        [ForeignKey("ParentId")]
        public int? ParentsId { get; set; }
        [JsonIgnore]
        public virtual Parents? Parents { get; set; }

        [JsonIgnore]
        public virtual List<TheResults>? Results { get; set; }   
       
    }
}
