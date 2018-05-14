using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace AuthorizeSample.Web.Models
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// Enumerated list of tasks that are required
        /// </summary>
        public string Tasks { get; set; }

        public override void OnAuthorization(HttpActionContext actionContext)
        {
            base.OnAuthorization(actionContext);
        }

        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            var isAuthorized = false;

            if (base.IsAuthorized(actionContext))
            {
                var authorizationService = new AuthorizationService() { Roles = Roles };
                var principal = ((ApiController)actionContext.ControllerContext.Controller).User;

                isAuthorized = authorizationService.IsAuthorized(principal);
            }

            return isAuthorized;
        }
    }
}