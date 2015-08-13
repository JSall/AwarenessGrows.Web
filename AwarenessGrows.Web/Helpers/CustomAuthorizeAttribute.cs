using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AwarenessGrows.Web.Helpers
{
    public class CustomAuthorizeAttribute
    {
    }
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class AuthorizeRolesAttribute : AuthorizeAttribute
    {
        /// <summary>
        /// Property to allow array instead of single string. 
        /// </summary>
        private string[] authorizedRoles;
        public string[] AuthorizedRoles
        {
            get { return authorizedRoles ?? new string[0]; }
            set { authorizedRoles = value; }
        }
        public AuthorizeRolesAttribute(params string[] roles)
            : base()
        {
            Roles = string.Join(",", roles);
        }
    }
}