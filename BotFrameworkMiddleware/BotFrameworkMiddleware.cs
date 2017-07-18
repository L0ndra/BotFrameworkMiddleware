using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace BotFrameworkMiddleware
{
    public class BotFrameworkMiddleware
    {
        private RequestDelegate _next;

        public BotFrameworkMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("I am bot");
        }
    }
}
