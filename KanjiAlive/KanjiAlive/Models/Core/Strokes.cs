using System.Collections.Generic;
using System.Linq;

namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     How to draw a character.
    /// </summary>
    public class Strokes
    {
        /// <summary>
        ///     Number of strokes in a character.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        ///     List of timings for drawing a character.
        /// </summary>
        public List<double> Timings { get; set; }

        /// <summary>
        ///     List of images that show how to draw the character.
        /// </summary>
        public List<string> Images { get; set; }

        protected bool Equals(Strokes other)
        {
            return this.Count == other.Count && this.Timings.SequenceEqual(other.Timings) && this.Images.SequenceEqual(other.Images);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((Strokes) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = this.Count;
                hashCode = (hashCode*397) ^ (this.Timings != null ? this.Timings.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Images != null ? this.Images.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}