namespace HomeTaskPustokReletion.Models
{
    public class BookTag
    {

        public Book Book { get; set; }

        public int BookId { get; set; }

        public int TagId { get; set; }

        public BookTag Tag { get; set; }
    }
}
