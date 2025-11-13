using StorProcedur_Core.Models;

namespace StorProcedur_Core.BL.Repository
{
    public class AccountRepsitory : IStudent
    {
        //private readonly StudentDbContext _student();

        //public AccountRepsitory(StudentDbContext db)
        //{
        //   this._sdb=db;
        //}
        public IEnumerable<District> lodeDistrict()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Taluka> lodeTaluka()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Village> lodeVillage()
        {
            throw new NotImplementedException();
        }

        public int SaveData()
        {
            throw new NotImplementedException();
        }
    }
}
