using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firebase_push_notification.Models
{
    public class MessageRequest
    {
            public string title { get; set; }
            public string body { get; set; }
            public string imageUrl { get; set; }
            public string param { get; set; }
            public string link { get; set; }
            public string deviceToken { get; set; }
        
    }
}
