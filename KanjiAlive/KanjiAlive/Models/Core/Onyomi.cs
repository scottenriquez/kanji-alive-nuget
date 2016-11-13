using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class Onyomi : Yomi
    {
        public string Katakana { get; set; }

        protected bool Equals(Onyomi other)
        {
            return string.Equals(Katakana, other.Katakana);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Onyomi) obj);
        }

        public override int GetHashCode()
        {
            return (Katakana != null ? Katakana.GetHashCode() : 0);
        }
    }
}
