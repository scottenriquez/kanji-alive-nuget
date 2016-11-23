namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     The name for a character.
    /// </summary>
    public class Name
    {
        /// <summary>
        ///     Hiragana text for a character's name.
        /// </summary>
        public string Hiragana { get; set; }

        /// <summary>
        ///     Romaji text for a character's name.
        /// </summary>
        public string Romaji { get; set; }

        protected bool Equals(Name other)
        {
            return string.Equals(this.Hiragana, other.Hiragana) && string.Equals(this.Romaji, other.Romaji);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((Name) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((this.Hiragana != null ? this.Hiragana.GetHashCode() : 0)*397) ^ (this.Romaji != null ? this.Romaji.GetHashCode() : 0);
            }
        }
    }
}