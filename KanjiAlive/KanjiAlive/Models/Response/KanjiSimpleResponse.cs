using KanjiAlive.Models.Core;

namespace KanjiAlive.Models.Response
{
    /// <summary>
    ///     Simple response from the API.
    /// </summary>
    public class KanjiSimpleResponse
    {
        /// <summary>
        ///     Simple metadata for a kanji character.
        /// </summary>
        public KanjiSimple Kanji { get; set; }

        /// <summary>
        ///     Simple metadata for a radical.
        /// </summary>
        public RadicalSimple Radical { get; set; }

        protected bool Equals(KanjiSimpleResponse other)
        {
            return Equals(this.Kanji, other.Kanji) && Equals(this.Radical, other.Radical);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((KanjiSimpleResponse) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((this.Kanji != null ? this.Kanji.GetHashCode() : 0)*397) ^ (this.Radical != null ? this.Radical.GetHashCode() : 0);
            }
        }
    }
}