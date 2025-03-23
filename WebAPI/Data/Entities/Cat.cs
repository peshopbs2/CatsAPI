namespace WebAPI.Data.Entities
{
    public class Cat : BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string Breed { get; set; }
        public string ImageUrl { get; set; }
        public virtual ICollection<Visit>? Visits { get; set; }
    }
}
