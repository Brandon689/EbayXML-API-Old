using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Multi_Platform_ECommerce.Ebay.Network
{
    public partial class XMLPost
    {
        public string PostFile(string localFile)
        {
            if (EbayUtil.ValidImgSize(localFile) == false)
            {
                return "";
            }
            string boundary = "MIME_boundary";
            string CRLF = "\r\n";
            HttpWebRequest? request = WebRequest.Create("https://api.ebay.com/ws/api.dll") as HttpWebRequest;
            request.Headers.Add("X-EBAY-API-COMPATIBILITY-LEVEL", "515");
            request.Headers.Add("X-EBAY-API-SITEID", "15");
            request.Headers.Add("X-EBAY-API-DETAIL-LEVEL", "0");
            request.Headers.Add("X-EBAY-API-CALL-NAME", "UploadSiteHostedPictures");
            request.ContentType = "multipart/form-data; boundary=" + boundary;
            request.Method = "POST";
            var auth = "";
            string payload1 = "--" + boundary + CRLF +
                "Content-Disposition: form-data; name=document" + CRLF +
                "Content-Type: text/xml; charset=\"UTF-8\"" + CRLF + CRLF +
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<UploadSiteHostedPicturesRequest xmlns=\"urn:ebay:apis:eBLBaseComponents\">" +
                "<PictureSet>Supersize</PictureSet>" +
                "<RequesterCredentials><eBayAuthToken>" + auth + "</eBayAuthToken></RequesterCredentials>" +
                "</UploadSiteHostedPicturesRequest>" +
                CRLF + "--" + boundary + CRLF +
                "Content-Disposition: form-data; name=image; filename=image" + CRLF +
                "Content-Type: application/octet-stream" + CRLF +
                "Content-Transfer-Encoding: binary" + CRLF + CRLF;

            string payload3 = CRLF + "--" + boundary + "--" + CRLF;

            byte[] postDataBytes1 = Encoding.ASCII.GetBytes(payload1);
            byte[] postDataBytes2 = Encoding.ASCII.GetBytes(payload3);
            byte[]? image = null;

            image = File.ReadAllBytes(localFile);
            int length = postDataBytes1.Length + image.Length + postDataBytes2.Length;
            request.ContentLength = length;

            using (Stream stream = request.GetRequestStream())
            {
                byte[] bytes = postDataBytes1.Concat(image).Concat(postDataBytes2).ToArray();
                var str = Encoding.Default.GetString(bytes);
                Console.WriteLine(postDataBytes1.Concat(image).Concat(postDataBytes2));
                stream.Write(bytes, 0, length);
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string output = string.Empty;
            using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                output = sr.ReadToEnd();
            }
            if (string.IsNullOrEmpty(output))
                return "";
            XmlDocument xmlResponse = new XmlDocument();
            xmlResponse.LoadXml(output);

            XmlNodeList list = xmlResponse.GetElementsByTagName("FullURL", "urn:ebay:apis:eBLBaseComponents");
            if (list[0] == null)
            {
                return "";
            }
            return list[0].InnerText;
        }
    }
}
