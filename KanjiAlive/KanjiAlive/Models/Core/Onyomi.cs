using Newtonsoft.Json;

namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     Chinese reading for a character.
    /// </summary>
    public class Onyomi : Yomi
    {
        /// <summary>
        ///     The katakana text for the Chinese reading of a character.
        /// </summary>
        [JsonProperty(PropertyName = "Katakana")]
        public string Katakana { get; set; }

        protected bool Equals(Onyomi other)
        {
            return string.Equals(this.Katakana, other.Katakana);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((Onyomi) obj);
        }

        public override int GetHashCode()
        {
            return this.Katakana != null ? this.Katakana.GetHashCode() : 0;
        }
    }
}