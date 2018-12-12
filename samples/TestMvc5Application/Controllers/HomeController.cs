using System.Web.Mvc;

namespace TestMvc5Application.Controllers
{
    public partial class HomeController : ControllerBase
    {
        public virtual ActionResult Index()
        {
            return View(MVC.Home.Views.Index);
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(MVC.Home.Views.About);
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View(MVC.Home.Views.Contact);
        }
    }
}
