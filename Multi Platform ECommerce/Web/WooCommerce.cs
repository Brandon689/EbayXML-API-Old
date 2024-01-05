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
    public static class WooCommerce
    {
        // base64 encode your password in form username:password for basic auth
        private static readonly string base64 = "";
        private static readonly HttpClient client = new();

        static WooCommerce()
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64);
            client.BaseAddress = new Uri("https://mysite.com/wp-json/wc/v3/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<string> Update(int productId, int quantity)
        {
            HttpRequestMessage request = new(HttpMethod.Put, UriProduct(productId))
            {
                Content = Content(JsonSerializer.Serialize(new EditQuantity(quantity)))
            };
            var res = await client.SendAsync(request);
            request.Dispose();
            return await res.Content.ReadAsStringAsync();
        }
        public static async Task<string> EditName(int productId, string name)
        {
            HttpRequestMessage request = new(HttpMethod.Put, UriProduct(productId))
            {
                Content = Content(JsonSerializer.Serialize(new EditName(name)))
            };
            var res = await client.SendAsync(request);
            request.Dispose();
            return await res.Content.ReadAsStringAsync();
        }
        public static async Task<string> Create(CreateStockUnit csu)
        {
            HttpRequestMessage request = new(HttpMethod.Post, new Uri(client.BaseAddress + "products"))
            {
                Content = Content(JsonSerializer.Serialize(csu))
            };
            var res = await client.SendAsync(request);
            request.Dispose();
            return await res.Content.ReadAsStringAsync();
        }

        public static async Task<string> GetAllProducts()
        {
            HttpRequestMessage request = new()
            {
                RequestUri = new Uri(client.BaseAddress + "products?per_page=20")
            };
            Console.WriteLine(request.RequestUri);
            var res = await client.SendAsync(request);
            request.Dispose();
            return await res.Content.ReadAsStringAsync();
        }

        public static async Task<string> GetProduct(int id)
        {
            HttpRequestMessage request = new()
            {
                RequestUri = UriProduct(id)
            };
            var res = await client.SendAsync(request);
            request.Dispose();
            return await res.Content.ReadAsStringAsync();         
        }

        public static List<SImage> Images(string[] urls)
        {
            List<SImage> s = new();
            foreach (string item in urls)
            {
                SImage i = new() { src = item };
                s.Add(i);
            }
            return s;
        }

        public static List<SCategory> Categories(int[] ids)
        {
            List<SCategory> s = new();
            foreach (int item in ids)
            {
                SCategory i = new() { id = item };
                s.Add(i);
            }
            return s;
        }

        private static Uri UriProduct(int id)
        {
            return new Uri($"{client.BaseAddress}products/{id}");
        }

        private static StringContent Content(string json)
        {
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
