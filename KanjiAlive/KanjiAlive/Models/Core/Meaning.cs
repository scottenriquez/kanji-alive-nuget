using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class Meaning
    {
        public string English { get; set; }

        protected bool Equals(Meaning other)
        {
            return string.Equals(English, other.English);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Meaning) obj);
        }

        public override int GetHashCode()
        {
            return (English != null ? English.GetHashCode() : 0);
        }
    }
}
