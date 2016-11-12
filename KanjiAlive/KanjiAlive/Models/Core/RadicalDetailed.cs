using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class RadicalDetailed
    {
        public string Character { get; set; }
        public int? Strokes { get; set; }
        public string Image { get; set; }
        public Position Position { get; set; }
        public Name Name { get; set; }
        public Meaning Meaning { get; set; }
        public List<string> Animation { get; set; }
    }
}
