using System.Collections.Specialized;

namespace Discord.Webhooks
{
    public class Webhook
    {
        
        public string WebhookUrl { get; set; }
        public string Message { get; set; }
        public string Username { get; set; }

        public void SendInstance()
        {
            Network.SendPost(this.WebhookUrl, new NameValueCollection()
            {
                {
                    "username",
                    this.Username
                },
                {
                    "content",
                    this.Message
                }
            });
        }
        
    }
}