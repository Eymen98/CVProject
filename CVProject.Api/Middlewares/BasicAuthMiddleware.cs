using Microsoft.Extensions.Options;
using System.Text;

namespace CVProject.Api.Middlewares
{
    public class BasicAuthMiddleware
    {
        private readonly RequestDelegate _next;
        private const string AUTH_HEADER = "Authorization";
        private readonly BasicAuthOptions _options;
        public BasicAuthMiddleware(RequestDelegate next, IOptions<BasicAuthOptions> options)
        {
            _next = next;
            _options = options.Value;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {

            if (httpContext.Request.Path.StartsWithSegments("/swagger"))//swagger'e girsin.
            {
                await _next(httpContext);
                return;
            }
          
            if (!httpContext.Request.Headers.ContainsKey(AUTH_HEADER))
            {
                httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await httpContext.Response.WriteAsync("Authorization header missing");
                return;
            }

            var authHeader = httpContext.Request.Headers[AUTH_HEADER].ToString();
            if (authHeader.StartsWith("Basic ", StringComparison.OrdinalIgnoreCase))
            {
                var encodedCredentials = authHeader.Substring("Basic ".Length).Trim();
                var decodedCredentials = Encoding.UTF8.GetString(Convert.FromBase64String(encodedCredentials));
                var credentials = decodedCredentials.Split(':');
                var username = credentials[0];
                var password = credentials[1];

                // Validate the credentials
                if (IsValidUser(username, password))
                {
                    await _next(httpContext);
                    return;
                }
            }

            httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await httpContext.Response.WriteAsync("Invalid username or password");
        }

        private bool IsValidUser(string username, string password)
        {
            return username == _options.UserName && password == _options.Password;
        }
    }
}
