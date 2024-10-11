namespace KPS_DojoM_models
{
    public class Athletes
    {
        public int? Id { get; set; }
        public int? AthleteKYU { get; set; }
        public string? AthleteName { get; set; }
        public DateTime? AthleteBirthdayDate { get; set; } 
        public string? AthleteAddress { get; set; }
        public string? AthleteEmail { get; set; }
        public int? AthleteCellPhone { get; set; }
        public int? AthleteNif { get; set; }
        public int? AthleteCcNumber { get; set; }
        public string? Club { get; set; }
        public int? AthleteClubMemberNumber { get; set; }
        public int? AssociationMemberNumber { get; set; }
        public int? CategoryId { get; set; }
        public virtual Categories? Categories { get; set; }
        public int? AssociationId { get; set; }
        public virtual Association? Association { get; set; }
        public int? ParentId { get; set; }
        public virtual Parents? Parents { get; set; }

        public List<TheResults>? Results { get; set; }   

       
    }
}
