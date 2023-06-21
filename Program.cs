using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace queteJson;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
    }


// Définition des classes pour représenter les données
public class Wind
{
    public double speed { get; set; }
    public int deg { get; set; }
}

public class Weather
{
    public int id { get; set; }
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
}

public class WeatherInfo
{
    public Dictionary<string, double> coord { get; set; }
    public List<Weather> weather { get; set; }
    public string @base { get; set; }
    public Dictionary<string, double> main { get; set; }
    public int visibility { get; set; }
    public Wind wind { get; set; }
    public Dictionary<string, int> clouds { get; set; }
    public int dt { get; set; }
    public Dictionary<string, object> sys { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public int cod { get; set; }
}

// Fonction de désérialisation
public static WeatherInfo DeserializeJson(string jsonString)
{
    return JsonConvert.DeserializeObject<WeatherInfo>(jsonString);
}

// Exemple d'utilisation
string jsonString = @"
{
  ""coord"": {
    ""lon"": -0.13,
    ""lat"": 51.51
  },
  ""weather"": [
    {
      ""id"": 300,
      ""main"": ""Drizzle"",
      ""description"": ""light intensity drizzle"",
      ""icon"": ""09d""
    },
    {
      ""id"": 800,
      ""main"": ""Clear"",
      ""description"": ""clear sky"",
      ""icon"": ""01n""
    }
  ],
  ""base"": ""stations"",
  ""main"": {
    ""temp"": 280.32,
    ""pressure"": 1012,
    ""humidity"": 81,
    ""temp_min"": 279.15,
    ""temp_max"": 281.15
  },
  ""visibility"": 10000,
  ""wind"": {
    ""speed"": 4.1,
    ""deg"": 80
  },
  ""clouds"": {
    ""all"": 90
  },
  ""dt"": 1485789600,
  ""sys"": {
    ""type"": 1,
    ""id"": 5091,
    ""message"": 0.0103,
    ""country"": ""GB"",
    ""sunrise"": 1485762037,
    ""sunset"": 1485794875
  },
  ""id"": 2643743,
  ""name"": ""London"",
  ""cod"": 200
}";

WeatherInfo weatherInfo = DeserializeJson(jsonString);




}
