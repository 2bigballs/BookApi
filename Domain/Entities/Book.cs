namespace Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Cover { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public List<Rating> Ratings { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
