using System.Text.Json.Serialization;

namespace HPlusSport.API.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]
        public virtual List<Product>? Products { get; set; }
    }
}
