using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace pop_maria_lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]

        public string Title { get; set; }
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }

        public decimal Price { get; set; }
        [Column(TypeName = "decimal(6, 2)")]

        [NotMapped]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; }


    }
}
