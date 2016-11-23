using System.Collections.Generic;
using System.Linq;

namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     Detailed metadata for a radical.
    /// </summary>
    public class RadicalDetailed
    {
        /// <summary>
        ///     The radical itself.
        /// </summary>
        public string Character { get; set; }

        /// <summary>
        ///     The number of strokes in a radical.
        /// </summary>
        public int? Strokes { get; set; }

        /// <summary>
        ///     A hyperlink to an image of the radical.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        ///     Position of a radical in a kanji character.
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        ///     The name of the radical.
        /// </summary>
        public Name Name { get; set; }

        /// <summary>
        ///     The English meaning of the radical.
        /// </summary>
        public Meaning Meaning { get; set; }

        /// <summary>
        ///     A list of hyperlinks to animation images.
        /// </summary>
        public List<string> Animation { get; set; }

        protected bool Equals(RadicalDetailed other)
        {
            return string.Equals(this.Character, other.Character) && this.Strokes == other.Strokes && string.Equals(this.Image, other.Image) && Equals(this.Position, other.Position) && Equals(this.Name, other.Name) && Equals(this.Meaning, other.Meaning) && this.Animation.SequenceEqual(other.Animation);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((RadicalDetailed) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = this.Character != null ? this.Character.GetHashCode() : 0;
                hashCode = (hashCode*397) ^ this.Strokes.GetHashCode();
                hashCode = (hashCode*397) ^ (this.Image != null ? this.Image.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Position != null ? this.Position.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Name != null ? this.Name.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Meaning != null ? this.Meaning.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Animation != null ? this.Animation.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}