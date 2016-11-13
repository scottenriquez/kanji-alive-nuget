using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class Position
    {
        public string Hiragana { get; set; }
        public string Romaji { get; set; }
        public string Icon { get; set; }

        protected bool Equals(Position other)
        {
            return string.Equals(Hiragana, other.Hiragana) && string.Equals(Romaji, other.Romaji) && string.Equals(Icon, other.Icon);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Position) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Hiragana != null ? Hiragana.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Romaji != null ? Romaji.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Icon != null ? Icon.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
