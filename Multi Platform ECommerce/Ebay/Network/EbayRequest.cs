using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Ebay.Network
{
    public class EbayRequest
    {
        public void SetHeader(HttpClient client)
        {
            client.BaseAddress = new Uri("https://api.ebay.com/ws/api.dll");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
            client.DefaultRequestHeaders.Add("X-EBAY-API-SITEID", "15");
            client.DefaultRequestHeaders.Add("X-EBAY-API-COMPATIBILITY-LEVEL", "1131");
        }

        public async Task<string> SendHttpRequest(string req, string xml, HttpMethod hp, HttpClient client)
        {        
            HttpRequestMessage request = new HttpRequestMessage(hp, "");
            request.Headers.Remove("X-EBAY-API-CALL-NAME"); // ?
            request.Headers.Add("X-EBAY-API-CALL-NAME", req);
            request.Content = new StringContent(xml, Encoding.UTF8, "text/xml");
            var res = await client.SendAsync(request);
            var content = await res.Content.ReadAsStringAsync();
            return content;
        }
    }
}
