using Newtonsoft.Json;


namespace Slovar.Models
{
    public class Usage
    {
        public int Id { get; set; }
        [JsonIgnore]
        public DictionaryEntry Entry { get; set; }
        public string Sentence { get; set; }
        public int Position { get; set; }
    }
}