using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models
{
    [Table("Employee")]
    public class Employee
    {
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string Age { get; set; }

    }
}