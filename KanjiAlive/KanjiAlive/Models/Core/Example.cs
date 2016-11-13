using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class Example
    {
        public string Japanese { get; set; }
        public Meaning Meaning { get; set; }
        public Audio Audio { get; set; }

        protected bool Equals(Example other)
        {
            return string.Equals(Japanese, other.Japanese) && Equals(Meaning, other.Meaning) && Equals(Audio, other.Audio);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Example) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Japanese != null ? Japanese.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Meaning != null ? Meaning.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Audio != null ? Audio.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
