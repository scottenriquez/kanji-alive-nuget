using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class Stroke
    {
        public int Count { get; set; }
        public List<double> Timings { get; set; }
        public List<string> Images { get; set; } 
    }
}
