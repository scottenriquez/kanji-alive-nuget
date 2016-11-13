using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class Audio
    {
        public string Opus { get; set; }
        public string Aac { get; set; }
        public string Ogg { get; set; }
        public string Mp3 { get; set; }

        protected bool Equals(Audio other)
        {
            return string.Equals(Opus, other.Opus) && string.Equals(Aac, other.Aac) && string.Equals(Ogg, other.Ogg) && string.Equals(Mp3, other.Mp3);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Audio) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Opus != null ? Opus.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Aac != null ? Aac.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Ogg != null ? Ogg.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Mp3 != null ? Mp3.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
