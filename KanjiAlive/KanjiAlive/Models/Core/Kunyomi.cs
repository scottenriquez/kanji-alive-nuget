namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     Japanese reading for a kanji character.
    /// </summary>
    public class Kunyomi : Yomi
    {
        /// <summary>
        ///     The hiragana text for the Japanese reading of a kanji character.
        /// </summary>
        public string Hiragana { get; set; }

        protected bool Equals(Kunyomi other)
        {
            return string.Equals(this.Hiragana, other.Hiragana);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((Kunyomi) obj);
        }

        public override int GetHashCode()
        {
            return this.Hiragana != null ? this.Hiragana.GetHashCode() : 0;
        }
    }
}