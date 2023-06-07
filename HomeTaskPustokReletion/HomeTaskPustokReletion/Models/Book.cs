using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeTaskPustokReletion.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Author Author { get; set; }

        public Genre Genre { get; set; }

        public int AuthorId { get; set; }

        public int GenreId { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<BookTag> BookTags { get; set; }
    }
}
