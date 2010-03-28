using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Web.Controllers
{
    public class RequiresAuthentication : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext  actionContext)
        {
            if(!actionContext.HttpContext.User.Identity.IsAuthenticated )
            {
                string redirectOnSuccess = actionContext.HttpContext.Request.Url.AbsolutePath;

                string redirectUrl = String.Format("?ReturnUrl={0}", redirectOnSuccess);
                string loginUrl = FormsAuthentication.LoginUrl + redirectUrl;
                actionContext.HttpContext.Response.Redirect(loginUrl,true);

            }
        }
    }
}
