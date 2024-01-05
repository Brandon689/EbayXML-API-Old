using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Multi_Platform_ECommerce.Web.SendJson
{
    public class Kohei
    {
        public int id { get; set; }
        //public string guid { get; set; }
        [JsonPropertyName("guid")]
        public Guid Guid { get; set; }

    }

    public class Guid
    {
        public string rendered { get; set; }
        public string raw { get; set; }
    }


    public class MediaItem
    {
        [JsonPropertyName("guid")]
        public Guid Guid { get; set; }


        [JsonPropertyName("id")]
        public int ImageID { get; set; }
        //[JsonPropertyName("date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public DateTime Date { get; set; }

        //[JsonPropertyName("date_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public DateTime DateGmt { get; set; }

        //[JsonPropertyName("guid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public Guid Guid { get; set; }

        //[JsonPropertyName("modified", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public DateTime Modified { get; set; }

        //[JsonPropertyName("modified_gmt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public DateTime ModifiedGmt { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        //[JsonPropertyName("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public MediaQueryStatus Status { get; set; }

        //[JsonPropertyName("type")]
        //public string Type { get; set; }

        //[JsonPropertyName("link")]
        //public string Link { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        //[JsonPropertyName("author")]
        //public int Author { get; set; }

        //[JsonPropertyName("comment_status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public OpenStatus? CommentStatus { get; set; }

        //[JsonPropertyName("ping_status")]
        //public OpenStatus? PingStatus { get; set; }

        [JsonPropertyName("alt_text")]
        public string AltText { get; set; }

        //[JsonPropertyName("caption")]
        //public Caption Caption { get; set; }

        //[JsonPropertyName("description")]
        //public Description Description { get; set; }

        //[JsonPropertyName("media_type")]
        //public MediaType MediaType { get; set; }

        //[JsonPropertyName("mime_type")]
        //public string MimeType { get; set; }
        //[JsonPropertyName("media_details")]
        //public MediaDetails MediaDetails { get; set; }

        //[JsonPropertyName("post", NullValueHandling = NullValueHandling.Ignore)]
        //public int Post { get; set; }

        //[JsonPropertyName("source_url")]
        //public string SourceUrl { get; set; }

        //[JsonPropertyName("meta", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public dynamic Meta { get; set; }

        //[JsonPropertyName("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        //public Links Links { get; set; }
    }
}
