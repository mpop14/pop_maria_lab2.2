using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;
namespace pop_maria_lab2.Models
{
 
            public class Publisher
    {
        public int ID { get; set; }
        public string PublisherName { get; set; }
        
        public ICollection<Book>? Books { get; set; }
     
    }
}
