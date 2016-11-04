using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanjiAlive.Models.Core;

namespace KanjiAlive.Models.Response
{
    public class KanjiDetailedResponse
    {
        public KanjiDetailed Kanji { get; set; }
        public RadicalDetailed Radical { get; set; }
        public References References { get; set; }
        public List<Example> Examples { get; set; } 
    }
}
