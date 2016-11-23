namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     Reading for a character.
    /// </summary>
    public class Yomi
    {
        /// <summary>
        ///     The romaji reading for a character.
        /// </summary>
        public string Romaji { get; set; }

        protected bool Equals(Yomi other)
        {
            return string.Equals(this.Romaji, other.Romaji);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((Yomi) obj);
        }

        public override int GetHashCode()
        {
            return this.Romaji != null ? this.Romaji.GetHashCode() : 0;
        }
    }
}