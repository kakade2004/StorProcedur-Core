using Microsoft.AspNetCore.Mvc;
using StorProcedur_Core.BL;
using StorProcedur_Core.Models;

namespace StorProcedur_Core.Controllers
{
    public class AccountController : Controller
    {
        private readonly StudentDbContext _Db;

        //private readonly IStudent _stud;

        //public AccountController(IStudent student) 
        //{
        //    _stud = student;
        //}
        public AccountController(StudentDbContext db)
        {
            _Db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LodeDistrict()
        {
            try
            {
                List<District> districts = _Db.district.ToList();
                return Json(districts);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult LodeTaluka( int id)
        {
            try
            {
               List<Taluka>taluka=_Db.talukas.Where(x=>x.DistrictId==id).ToList();
                return Json(taluka);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public IActionResult LodeVillage(int id)
        {
            try
            {
                List<Village> villages = _Db.village.Where(x => x.TalukaId ==id).ToList();
                return Json(villages);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public  IActionResult SaveData(StudentRecord studentRecord)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Db.studentRecords.Add(studentRecord);
                    _Db.SaveChanges();
                    return Json(" ");
                }

            }
            catch (Exception)
            {

                throw;
            }
            return View();
        }

        public IActionResult LodeData()
        {
            dynamic table = (from s in _Db.studentRecords
                             join v in _Db.village on s.VillageId equals v.VillageId
                             join t in _Db.talukas on v.TalukaId equals t.TalukaId
                             join d in _Db.district on t.TalukaId equals d.DistrictId

                             select new
                             {
                                 s.Id,
                                 s.Name,
                                 s.Email,
                                 s.Phone,
                                 v.VillageName,
                                 t.TalukaName,
                                 d.DistrictName

                             }).ToList();

            return Json(table);
        }
    }
}
