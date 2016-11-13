using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class CharacterSimple
    {
        public string Character { get; set; }
        public int Stroke { get; set; }

        protected bool Equals(CharacterSimple other)
        {
            return string.Equals(Character, other.Character) && Stroke == other.Stroke;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CharacterSimple) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Character != null ? Character.GetHashCode() : 0)*397) ^ Stroke;
            }
        }
    }
}
