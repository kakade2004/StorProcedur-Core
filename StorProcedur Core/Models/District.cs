using System.ComponentModel.DataAnnotations;

namespace StorProcedur_Core.Models
{
    public class District
    {
        [Key]
        public int DistrictId { get; set; }
        [Required]
        public string DistrictName { get; set; }
    }
}
