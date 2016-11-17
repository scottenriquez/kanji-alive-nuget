using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanjiAlive.Models.Core;

namespace KanjiAlive.Models.Response
{
    public class KanjiDetailedResponse
    {
        public KanjiDetailed Kanji { get; set; }
        public RadicalDetailed Radical { get; set; }
        public References References { get; set; }
        public List<Example> Examples { get; set; }

        protected bool Equals(KanjiDetailedResponse other)
        {
            return Equals(Kanji, other.Kanji) && Equals(Radical, other.Radical) && Equals(References, other.References) && Examples.SequenceEqual(Examples);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((KanjiDetailedResponse) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Kanji != null ? Kanji.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Radical != null ? Radical.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (References != null ? References.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Examples != null ? Examples.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
