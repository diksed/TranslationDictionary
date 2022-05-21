using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationDictionary.DAL.Entities
{
    public class WordList
    {
        public int id { get; set; }
        public string firstWord { get; set; }
        public string secondWord { get; set; }
        public override string ToString()
        {
            return $"{firstWord,-5} == {secondWord,-10}";
        }
    }
}
