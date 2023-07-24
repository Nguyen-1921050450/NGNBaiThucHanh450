using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo.Models
{
    [Table("Person")]
    public class Person
    {
        [Key] 
        public string Fullname { get; set; }
        public string ID { get; set; }
        public DateTime BirthDay { get; set; }
        
    }
}