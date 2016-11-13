using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class References
    {
        public int? Grade { get; set; }
        public string Kodansha { get; set; }
        public string Classic_Nelson { get; set; }

        protected bool Equals(References other)
        {
            return Grade == other.Grade && string.Equals(Kodansha, other.Kodansha) && string.Equals(Classic_Nelson, other.Classic_Nelson);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((References) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Grade.GetHashCode();
                hashCode = (hashCode*397) ^ (Kodansha != null ? Kodansha.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Classic_Nelson != null ? Classic_Nelson.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
