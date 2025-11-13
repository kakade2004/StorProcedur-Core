using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace StorProcedur_Core.Models
{
    public class StudentRecord
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email {  get; set; }
        [Required]
        public string Phone {  get; set; }
        [Required]
        public int VillageId {  get; set; }
    }
}
