
using System.Text.Json.Serialization;

namespace MauiBookApp.Models
{
    public class User
    {
        [JsonPropertyName("Id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Buecheranzahl")]
        public string Buecheranzahl { get; set;}

        [JsonPropertyName("UserList")]
        public List<User> UserList { get; set;}

        public User() 
        { 
        }
    }
}
