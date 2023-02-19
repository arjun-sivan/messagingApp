using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column("EmployeeName", TypeName = "varchar(200)")]
        public string EmployeeName { get; set; }
        [Column("Department", TypeName = "varchar(200)")]
        public string Department { get; set; }
    }
}
