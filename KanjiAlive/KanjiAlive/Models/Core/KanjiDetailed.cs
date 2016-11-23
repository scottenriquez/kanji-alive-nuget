namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     Detailed metadata for a kanji character.
    /// </summary>
    public class KanjiDetailed
    {
        /// <summary>
        ///     The kanji character itself.
        /// </summary>
        public string Character { get; set; }

        /// <summary>
        ///     The English meaning for the kanji character.
        /// </summary>
        public Meaning Meaning { get; set; }

        /// <summary>
        ///     How to draw the kanji character.
        /// </summary>
        public Strokes Strokes { get; set; }

        /// <summary>
        ///     The Chinese reading for the kanji character.
        /// </summary>
        public Onyomi Onyomi { get; set; }

        /// <summary>
        ///     The Japanese reading for the kanji character.
        /// </summary>
        public Kunyomi Kunyomi { get; set; }

        /// <summary>
        ///     Hyperlinks to videos for the kanji character.
        /// </summary>
        public Video Video { get; set; }

        protected bool Equals(KanjiDetailed other)
        {
            return string.Equals(this.Character, other.Character) && Equals(this.Meaning, other.Meaning) && Equals(this.Strokes, other.Strokes) && Equals(this.Onyomi, other.Onyomi) && Equals(this.Kunyomi, other.Kunyomi) && Equals(this.Video, other.Video);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((KanjiDetailed) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = this.Character != null ? this.Character.GetHashCode() : 0;
                hashCode = (hashCode*397) ^ (this.Meaning != null ? this.Meaning.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Strokes != null ? this.Strokes.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Onyomi != null ? this.Onyomi.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Kunyomi != null ? this.Kunyomi.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Video != null ? this.Video.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}