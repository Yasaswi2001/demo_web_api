using System.ComponentModel.DataAnnotations;
namespace demo_web_api.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }  //nullable property
        public string? designation { get; set; }
        [DataType(DataType.Date)]
        public DateTime? JoinDate { get; set; }

    }
}
