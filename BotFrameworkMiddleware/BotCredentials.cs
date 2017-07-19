using System;
using System.Collections.Generic;
using System.Text;

namespace BotFrameworkMiddleware
{
    public class BotCredentials
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }

    public class BotTokenResponse
    {
        public string access_token { get; set; }
    }
}
