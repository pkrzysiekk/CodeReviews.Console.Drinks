using System.Text.Json.Serialization;


namespace DrinksInfo.Models
{
    public class Drinks
    {
        [JsonPropertyName("drinks")]
        public List<Drink> DrinksList { get; set; }
    }
}
