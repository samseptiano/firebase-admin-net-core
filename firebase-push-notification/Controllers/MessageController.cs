using firebase_push_notification.Models;
using FirebaseAdmin.Messaging;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firebase_push_notification.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> SendMessageAsync([FromBody] MessageRequest request)
        {
            var message = new Message()
            {
                Notification = new Notification
                {
                    Title = request.title,
                    Body = request.body,
                },
                Data = new Dictionary<string, string>()
                {
                    ["link"] = request.link,
                    ["param"] = request.param,

                },
                Token = request.deviceToken
            };

            var messaging = FirebaseMessaging.DefaultInstance;
            var result = await messaging.SendAsync(message);

            if (!string.IsNullOrEmpty(result))
            {
                // Message was sent successfully
                return Ok("Message sent successfully!");
            }
            else
            {
                // There was an error sending the message
                throw new Exception("Error sending the message.");
            }
        }
    }
}
