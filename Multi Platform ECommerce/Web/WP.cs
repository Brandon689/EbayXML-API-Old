using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Multi_Platform_ECommerce.Web.SendJson;

namespace Multi_Platform_ECommerce.Web
{
    public static class WP
    {
        private static readonly string base64;
        private static readonly HttpClient client = new();

        static WP()
        {
//            Application Passwords

//Application passwords allow authentication via non-interactive systems, such as XML - RPC or the REST API, without providing your actual password. Application passwords can be easily revoked. They cannot be used for traditional logins to your website.
//New Application Password Name

//Required to create an Application Password, but not to update the user.

//Name    Created Last Used   Last IP Revoke
// the password here is an application password u can make on wordpress admin under user admin page
            base64 = Base64Encode("username:app pass");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64);
            client.BaseAddress = new Uri("https://mysite.com/wp-json/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static async Task<string> GetIMG(int id)
        {
            HttpRequestMessage request = new()
            {
                RequestUri = new Uri($"{client.BaseAddress}wp/v2/media/109")
            };
            var res = await client.SendAsync(request);
            request.Dispose();
            return await res.Content.ReadAsStringAsync();
        }

        public static async Task<Kohei> CreateIMG(string filepath, string filename)
        {
            using StreamContent content = new(File.OpenRead(filepath));
            string extension = filepath.Split('.').Last();
            filename += "." + extension;
            content.Headers.TryAddWithoutValidation("Content-Type", MimeTypeHelper.GetMIMETypeFromExtension(extension));
            content.Headers.Add("Content-Disposition", $"attachment; filename={filename}");
            HttpRequestMessage request = new()
            {
                RequestUri = new Uri($"{client.BaseAddress}wp/v2/media"),
                Method = HttpMethod.Post,
                Content = content
            };
            var res = await client.SendAsync(request);
            request.Dispose();
            var a = await res.Content.ReadAsStringAsync();
            var b = JsonSerializer.Deserialize<dynamic>(a);
            var c = JsonSerializer.Deserialize<Kohei>(a);
            return c;
        }
        public static async Task<string> UpdateMedia(MediaItem m)
        {
            HttpRequestMessage request = new(HttpMethod.Post, new Uri($"{client.BaseAddress}wp/v2/media/{m.ImageID}"))
            {
                Content = Content(JsonSerializer.Serialize(m))
            };
            var res = await client.SendAsync(request);
            request.Dispose();
            return await res.Content.ReadAsStringAsync();
        }

        private static StringContent Content(string json)
        {
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
