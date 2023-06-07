using System.ComponentModel.DataAnnotations;

namespace HomeTaskPustokReletion.Models
{
    public class Image
    {

        public int Id { get; set; }

        public string Urll { get; set; }

        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
