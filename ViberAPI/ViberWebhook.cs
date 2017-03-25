using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViberAPI
{
    public class ViberWebhook
    {
        private string _authToken;
        private string _endpoint;
        public Subscription Subscriptions { get; private set; }
        public ViberWebhook(string authToken, string endpoint)
        {
            _authToken = authToken;
            _endpoint = endpoint;
        }

        public void SetSubscriptions(Subscription subscriptions)
        {
            Subscriptions = subscriptions;
        }

        public StatusCode Register(this ViberWebhook webhook)
        {

            return StatusCode.OK;
        }
    }
    
}
