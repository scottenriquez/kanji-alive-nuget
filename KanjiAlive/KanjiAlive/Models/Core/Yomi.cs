using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class Yomi
    {
        public string Romaji { get; set; }

        protected bool Equals(Yomi other)
        {
            return string.Equals(Romaji, other.Romaji);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Yomi) obj);
        }

        public override int GetHashCode()
        {
            return (Romaji != null ? Romaji.GetHashCode() : 0);
        }
    }
}
