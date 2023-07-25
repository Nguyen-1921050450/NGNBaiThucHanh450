using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Dog")]
    public class Dog : Animal
    {
        
        public string Gender { get; set; }
    }
}