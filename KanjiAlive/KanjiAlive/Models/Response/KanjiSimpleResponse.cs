using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanjiAlive.Models.Core;

namespace KanjiAlive.Models.Response
{
    public class KanjiSimpleResponse
    {
        public KanjiSimple Kanji { get; set; }
        public RadicalSimple Radical { get; set; }

        protected bool Equals(KanjiSimpleResponse other)
        {
            return Equals(Kanji, other.Kanji) && Equals(Radical, other.Radical);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((KanjiSimpleResponse) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Kanji != null ? Kanji.GetHashCode() : 0)*397) ^ (Radical != null ? Radical.GetHashCode() : 0);
            }
        }
    }
}
