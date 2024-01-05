

namespace BookStore_Models.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int AuthorId { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
