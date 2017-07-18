using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotFrameworkMiddleware
{
    public static class BotFrameworkMiddelwareExtensions
    {
        public static IApplicationBuilder UseBotFramework(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<BotFrameworkMiddleware>();
        }
    }
}
