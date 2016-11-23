namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     Position of a radical in a kanji character.
    /// </summary>
    public class Position
    {
        /// <summary>
        ///     Hiragana text for a position.
        /// </summary>
        public string Hiragana { get; set; }

        /// <summary>
        ///     Romaji text for a position.
        /// </summary>
        public string Romaji { get; set; }

        /// <summary>
        ///     Hyperlink to an image file for the icon for a position.
        /// </summary>
        public string Icon { get; set; }

        protected bool Equals(Position other)
        {
            return string.Equals(this.Hiragana, other.Hiragana) && string.Equals(this.Romaji, other.Romaji) && string.Equals(this.Icon, other.Icon);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((Position) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = this.Hiragana != null ? this.Hiragana.GetHashCode() : 0;
                hashCode = (hashCode*397) ^ (this.Romaji != null ? this.Romaji.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Icon != null ? this.Icon.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}