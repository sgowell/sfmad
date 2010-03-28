using System;
using System.Web.Mvc;
using System.Web.Routing;
using Web.Data;
using Web.Models;
using Web.Models.Data;

namespace Web.Controllers
{

    [HandleError]
    public class AccountController : Controller
    {
        protected IUserRepository userRepository;
        public IFormsAuthenticationService FormsService { get; set; }
        public AccountController(IUserRepository userRepository )
        {
            this.userRepository = userRepository;
            this.FormsService = new FormsAuthenticationService();
        }

        public ActionResult LogOn()
        {
            return View();
        }

         [HttpPost]
        public ActionResult LogOn(User model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (userRepository.ValidateUser(model.UserName, model.Password))
                {
                    FormsService.SignIn(model.UserName, model.RememberMe);
                    if (!String.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }
   

    }
}
