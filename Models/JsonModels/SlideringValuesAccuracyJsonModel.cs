using Newtonsoft.Json;

namespace DataEnteringQuality.Models.JsonModels
{
    public class SlideringValuesAccuracyJsonModel
    {
        [JsonProperty("WARTOŚĆ ZADANA")]
        public int ValueToSet { get; set; }

        [JsonProperty("WARTOŚC USTAWIONA")]
        public string ValueFromTest { get; set; }

        [JsonProperty("DOKŁADNOŚĆ USTAWIENIA WSKAŹNIKA")]
        public string Accuracy { get; set; }
    }
}