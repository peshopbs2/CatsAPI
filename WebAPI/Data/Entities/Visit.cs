using System.Text.Json.Serialization;

namespace WebAPI.Data.Entities
{
    public class Visit
    {
        public int CatId { get; set; }
        [JsonIgnore]
        public virtual Cat? Cat { get; set; }
        public int VetId { get; set; }
        [JsonIgnore]
        public virtual Vet? Vet { get; set; }
        public DateTime VisitDate { get; set; }
        public string Description { get; set; }
    }
}