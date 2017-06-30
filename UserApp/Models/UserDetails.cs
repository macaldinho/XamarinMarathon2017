using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;

namespace UserApp.Models
{
    public class UserDetails
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "age")]
        public int Age { get; set; }

        [Version]
        public string Version { get; set; }
    }
}