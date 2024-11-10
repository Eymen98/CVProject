using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CVProject.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class BasicAuthAttribute : TypeFilterAttribute
    {
        public BasicAuthAttribute() : base(typeof(BasicAuthFilter))
        {
        }
    }
    public class BasicAuthFilter : IAuthorizationFilter
    {
        public BasicAuthFilter()
        {
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                string authHeader = context.HttpContext.Request.Headers["Authorization"];
                if (authHeader != null)
                {
                    var authHeaderValue = AuthenticationHeaderValue.Parse(authHeader);
                    if (authHeaderValue.Scheme.Equals(AuthenticationSchemes.Basic.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        var credentials = Encoding.UTF8.GetString(Convert.FromBase64String(authHeaderValue.Parameter ?? string.Empty)).Split(':', 2);
                        if (credentials.Length == 2)
                        {
                            if (IsAuthorized(credentials[0], credentials[1]))
                            {
                                return;
                            }
                            else
                            {
                                ReturnUnauthorizedResult(context, "The username or password is incorrect. Please call the service provider");
                                return;
                            }
                        }
                    }
                }
                ReturnUnauthorizedResult(context, "The username or password is incorrect. Please call the service provider");
            }
            catch (FormatException ex)
            {
                ReturnUnauthorizedResult(context, ex.ToString());
            }
        }
        private bool IsAuthorized(string username, string password)
        {
            return username == "eymen" && password == "Cv0Project@!";
        }
        private void ReturnUnauthorizedResult(AuthorizationFilterContext context, string message)
        {
            // Return 401 and a basic authentication challenge (causes browser to show login dialog)
            context.HttpContext.Response.Headers["WWW-Authenticate"] = message;
            context.Result = new UnauthorizedResult();
        }

    }
}
