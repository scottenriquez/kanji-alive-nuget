using Newtonsoft.Json;

namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     Basic metadata for a character.
    /// </summary>
    public class CharacterSimple
    {
        /// <summary>
        ///     The character itself.
        /// </summary>
        [JsonProperty(PropertyName = "Character")]
        public string Character { get; set; }

        /// <summary>
        ///     The number of strokes for the character.
        /// </summary>
        [JsonProperty(PropertyName = "Stroke")]
        public int Stroke { get; set; }

        protected bool Equals(CharacterSimple other)
        {
            return string.Equals(this.Character, other.Character) && this.Stroke == other.Stroke;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((CharacterSimple) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((this.Character != null ? this.Character.GetHashCode() : 0)*397) ^ this.Stroke;
            }
        }
    }
}