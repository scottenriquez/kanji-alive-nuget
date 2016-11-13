using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class Kunyomi : Yomi
    {
        public string Hiragana { get; set; }

        protected bool Equals(Kunyomi other)
        {
            return string.Equals(Hiragana, other.Hiragana);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Kunyomi) obj);
        }

        public override int GetHashCode()
        {
            return (Hiragana != null ? Hiragana.GetHashCode() : 0);
        }
    }
}
