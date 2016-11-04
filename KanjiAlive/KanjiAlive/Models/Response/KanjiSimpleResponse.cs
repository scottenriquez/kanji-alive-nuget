using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanjiAlive.Models.Core;

namespace KanjiAlive.Models.Response
{
    public class KanjiSimpleResponse
    {
        public KanjiSimple Kanji { get; set; }
        public RadicalSimple Radical { get; set; }
    }
}
