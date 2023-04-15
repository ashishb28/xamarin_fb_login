using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace xam.Login
{
    public class Data
    {
        [JsonProperty("is_silhouette")]
        public bool IsSilhouette { get; set; }
        public int Height { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
    }

    public class Picture
    {
        public Data Data { get; set; }
    }

    public class FacebookProfile
    {
        [JsonProperty("id")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
    public class NetworkAuthData
    {
       
            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("pin")]
            public string Pin { get; set; } = string.Empty;

            [JsonProperty("Id")]
            public string Id { get; set; }
        
    }

}
