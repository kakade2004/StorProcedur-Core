using System.ComponentModel.DataAnnotations;

namespace StorProcedur_Core.Models
{
    public class Taluka
    {
        [Key]
        public int TalukaId { get; set; }
        [Required]
        public string TalukaName { get; set; }
        [Required]
        public int DistrictId { get; set; }
    }
}
