using Newtonsoft.Json;

namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     An English translation.
    /// </summary>
    public class Meaning
    {
        /// <summary>
        ///     The English translation text.
        /// </summary>
        [JsonProperty(PropertyName = "Meaning")]
        public string English { get; set; }

        protected bool Equals(Meaning other)
        {
            return string.Equals(this.English, other.English);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((Meaning) obj);
        }

        public override int GetHashCode()
        {
            return this.English != null ? this.English.GetHashCode() : 0;
        }
    }
}