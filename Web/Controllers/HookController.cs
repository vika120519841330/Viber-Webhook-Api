using System.Linq;
using System.Net;
using System.Web.Http;
using ViberAPI;
using ViberAPI.Models.MessageTypes;

namespace Web.Controllers
{
    public class HookController : ApiController
    {

        ViberWebhook webhook = new ViberWebhook(
            authToken: "YOUR-VIBER-PA-API-TOKEN",
            endpoint: "https://not_self_signed_sertificate.com/hook/receiveMessage",
            subscription: Subscription.Subscribed | Subscription.ConversationStarted);

        [HttpPost]
        public HttpStatusCode ReceiveMessage(string message)
        {
            return HttpStatusCode.OK;
        }

        [HttpGet]
        public string RegisterWebhook()
        {
            return webhook.Register().ToString();
        }

        [HttpGet]
        public string Post(string message)
        {
            Message post = new Message()
            {
                auth_token = webhook.AuthToken,
                from = webhook.GetPublicAccountInfo().members.FirstOrDefault(x => x.role == "admin").id,
                type = "text",
                text = message
            };
            return webhook.Post(post);
        }
    }
}
