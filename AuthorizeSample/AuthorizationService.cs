using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AuthorizeSample
{
    public class AuthorizationService
    {
        public string Roles { get; set; }

        public bool IsAuthorized(IPrincipal principal)
        {
            return false;
        }
    }
}
