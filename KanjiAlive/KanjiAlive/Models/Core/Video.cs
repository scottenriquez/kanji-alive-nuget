using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class Video
    {
        public string Poster { get; set; }
        public string Mp4 { get; set; }
        public string Webm { get; set; }

        protected bool Equals(Video other)
        {
            return string.Equals(Poster, other.Poster) && string.Equals(Mp4, other.Mp4) && string.Equals(Webm, other.Webm);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Video) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Poster != null ? Poster.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Mp4 != null ? Mp4.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Webm != null ? Webm.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
