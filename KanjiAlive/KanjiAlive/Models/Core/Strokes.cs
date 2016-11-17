using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class Strokes
    {
        public int Count { get; set; }
        public List<double> Timings { get; set; }
        public List<string> Images { get; set; }

        protected bool Equals(Strokes other)
        {
            return Count == other.Count && Timings.SequenceEqual(other.Timings) && Images.SequenceEqual(other.Images);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Strokes) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Count;
                hashCode = (hashCode*397) ^ (Timings != null ? Timings.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Images != null ? Images.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
