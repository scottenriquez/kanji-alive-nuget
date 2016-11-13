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
        public Strokes Strokes { get; set; }
        public Onyomi Onyomi { get; set; }
        public Kunyomi Kunyomi { get; set; }
        public Video Video { get; set; }

        protected bool Equals(KanjiDetailed other)
        {
            return string.Equals(Character, other.Character) && Equals(Meaning, other.Meaning) && Equals(Strokes, other.Strokes) && Equals(Onyomi, other.Onyomi) && Equals(Kunyomi, other.Kunyomi) && Equals(Video, other.Video);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((KanjiDetailed) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Character != null ? Character.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Meaning != null ? Meaning.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Strokes != null ? Strokes.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Onyomi != null ? Onyomi.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Kunyomi != null ? Kunyomi.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Video != null ? Video.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
