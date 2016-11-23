namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     An example use of a kanji character.
    /// </summary>
    public class Example
    {
        /// <summary>
        ///     The example text in Japanese.
        /// </summary>
        public string Japanese { get; set; }

        /// <summary>
        ///     The English translation for the example use.
        /// </summary>
        public Meaning Meaning { get; set; }

        /// <summary>
        ///     Hyperlinks to the audio for the example.
        /// </summary>
        public Audio Audio { get; set; }

        protected bool Equals(Example other)
        {
            return string.Equals(this.Japanese, other.Japanese) && Equals(this.Meaning, other.Meaning) && Equals(this.Audio, other.Audio);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((Example) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = this.Japanese != null ? this.Japanese.GetHashCode() : 0;
                hashCode = (hashCode*397) ^ (this.Meaning != null ? this.Meaning.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Audio != null ? this.Audio.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}