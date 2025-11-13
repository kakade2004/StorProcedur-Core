using StorProcedur_Core.Models;

namespace StorProcedur_Core.BL
{
    public interface IStudent
    {
        IEnumerable<District> lodeDistrict();

        IEnumerable<Taluka> lodeTaluka();

        IEnumerable<Village> lodeVillage();


        public int SaveData();
    }
}
