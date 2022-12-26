using Models.Interfaces;
using System;
using System.Text.Json.Serialization;

namespace Models
{
    public class User : IUser
    {
        [JsonPropertyName("id")]
        public int ID { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
