using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Animal")]
    public class Animal
    {   
        [Key]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Loai { get; set; }  

    }
}