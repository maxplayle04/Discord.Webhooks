using System.Collections.Specialized;
using System.Net;

namespace Discord.Webhooks
{
    internal class Network
    {

        public static byte[] SendPost(string uri, NameValueCollection pairs)
        {
            using (WebClient client = new WebClient())
            {
                return client.UploadValues(uri, pairs);
            }
        }
    
    }
}