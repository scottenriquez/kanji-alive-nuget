using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class Name
    {
        public string Hiragana { get; set; }
        public string Romaji { get; set; }

        protected bool Equals(Name other)
        {
            return string.Equals(Hiragana, other.Hiragana) && string.Equals(Romaji, other.Romaji);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Name) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Hiragana != null ? Hiragana.GetHashCode() : 0)*397) ^ (Romaji != null ? Romaji.GetHashCode() : 0);
            }
        }
    }
}
