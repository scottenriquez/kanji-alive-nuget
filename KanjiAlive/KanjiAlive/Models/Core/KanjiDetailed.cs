using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class KanjiDetailed
    {
        public string Character { get; set; }
        public Meaning Meaning { get; set; }
        public Stroke Strokes { get; set; }
        public Onyomi Onyomi { get; set; }
        public Kunyomi Kunyomi { get; set; }
        public Video Video { get; set; }
    }
}
