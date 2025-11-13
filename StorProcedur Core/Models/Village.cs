using System.ComponentModel.DataAnnotations;
namespace StorProcedur_Core.Models
{
    public class Village
    {
        [Key]
        public int VillageId { get; set; }
        [Required]
        public string VillageName {  get; set; }
        [Required]

        public int TalukaId {  get; set; }
    }
}
