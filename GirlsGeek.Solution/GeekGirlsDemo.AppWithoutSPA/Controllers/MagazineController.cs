using System.Web.Mvc;
using GeekGirlsDemo.Business;
using GeekGirlsDemo.Business.Entities;

namespace GeekGirlsDemo.AppWithoutSPA.Controllers
{
    public class MagazineController : Controller
    {
        public ActionResult Index()
        {
            var magazines = BusinessManager.MagazineService.GetMagazinesByYear(2006);
            return View(magazines);
        }

        public ActionResult GetMagazinesByYear(int year)
        {
            var magazines = BusinessManager.MagazineService.GetMagazinesByYear(year);

            return View("Index", magazines);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Magazine());
        }

        [HttpPost]
        public ActionResult Create(Magazine magazine)
        {
            if(!ModelState.IsValid) return View();

            BusinessManager.MagazineService.AddMagazine(magazine);

            return RedirectToAction("Index");
        }

    }
}