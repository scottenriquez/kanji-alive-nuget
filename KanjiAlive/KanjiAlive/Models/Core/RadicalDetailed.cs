using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanjiAlive.Models.Core
{
    public class RadicalDetailed
    {
        public string Character { get; set; }
        public int? Strokes { get; set; }
        public string Image { get; set; }
        public Position Position { get; set; }
        public Name Name { get; set; }
        public Meaning Meaning { get; set; }
        public List<string> Animation { get; set; }

        protected bool Equals(RadicalDetailed other)
        {
            return string.Equals(Character, other.Character) && Strokes == other.Strokes && string.Equals(Image, other.Image) && Equals(Position, other.Position) && Equals(Name, other.Name) && Equals(Meaning, other.Meaning) && Equals(Animation, other.Animation);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((RadicalDetailed) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Character != null ? Character.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ Strokes.GetHashCode();
                hashCode = (hashCode*397) ^ (Image != null ? Image.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Position != null ? Position.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Meaning != null ? Meaning.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Animation != null ? Animation.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}
