﻿
using System.Text.Json.Serialization;


namespace DrinksInfo.Models
{
    public class Drink
    {
        [JsonPropertyName("strDrink")]
        public string Name { get; set; }
        [JsonPropertyName("idDrink")]
        public string Id { get; set; }
        [JsonPropertyName("strInstructions")]
        public string Instructions { get; set; }
    }
}
