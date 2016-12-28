using System.Collections.Generic;
using System.Linq;
using KanjiAlive.Models.Core;
using Newtonsoft.Json;

namespace KanjiAlive.Models.Response
{
    /// <summary>
    ///     Detailed response from the API.
    /// </summary>
    public class KanjiDetailedResponse
    {
        /// <summary>
        ///     Detailed metadata for a kanji character.
        /// </summary>
        [JsonProperty(PropertyName = "Kanji")]
        public KanjiDetailed Kanji { get; set; }

        /// <summary>
        ///     Detailed metadata for a radical.
        /// </summary>
        [JsonProperty(PropertyName = "Radical")]
        public RadicalDetailed Radical { get; set; }

        /// <summary>
        ///     Index information for a kanji character in common references.
        /// </summary>
        [JsonProperty(PropertyName = "References")]
        public References References { get; set; }

        /// <summary>
        ///     Example uses of a kanji character.
        /// </summary>
        [JsonProperty(PropertyName = "Examples")]
        public List<Example> Examples { get; set; }

        protected bool Equals(KanjiDetailedResponse other)
        {
            return Equals(this.Kanji, other.Kanji) && Equals(this.Radical, other.Radical) && Equals(this.References, other.References) && this.Examples.SequenceEqual(this.Examples);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((KanjiDetailedResponse) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = this.Kanji != null ? this.Kanji.GetHashCode() : 0;
                hashCode = (hashCode*397) ^ (this.Radical != null ? this.Radical.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.References != null ? this.References.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Examples != null ? this.Examples.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}