using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Slovar.Models
{
    [ResponseCache(Duration = 86400, Location = ResponseCacheLocation.Client)]
    public class DictionaryEntry
    {
        private string _lemma;
        public int Id { get; set; }
        public string Lemma
        {
            get
            {
                return _lemma;
            }
            set
            {
                _lemma = value;
                LemmaForSearch = new LemmaNormalizer(_lemma).Normalize();
            }
        }
        public string Definition { get; set; }
        public int? StressIndex { get; set; }
        public string Translation { get; set; }
        public string LemmaForSearch { get; private set; }
        [InverseProperty("Entry")]
        public List<Usage> Usages { get; set; }

        public DictionaryEntry()
        {
            Usages = new List<Usage>();
        }
    }
}