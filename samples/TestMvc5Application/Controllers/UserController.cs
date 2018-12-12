using System;
using System.Web.Mvc;
using TestMvc5Application.Models.User;

namespace TestMvc5Application.Controllers
{
    public partial class UserController : Controller
    {
        [HttpGet]
        public virtual ActionResult Details(int id, string name)
        {
            UserDetails model = new UserDetails()
            {
                UserID = id,
                Name = name ?? "Test Name"
            };
            return View(MVC.User.Views.ViewNames.Details);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public virtual ActionResult Details(UserDetails model)
        {
            return RedirectToAction(MVC.User.Details(model.UserID, model.Name));
        }

        [HttpGet]
        public virtual ActionResult Stropping(string @default)
        {
            throw new NotImplementedException();
        }
    }
}
