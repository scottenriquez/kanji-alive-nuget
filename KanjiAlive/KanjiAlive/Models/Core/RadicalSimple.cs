using Newtonsoft.Json;

namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     Simple metadata for a radical.
    /// </summary>
    public class RadicalSimple : CharacterSimple
    {
        /// <summary>
        ///     The order of the radical.
        /// </summary>
        [JsonProperty(PropertyName = "Order")]
        public int Order { get; set; }

        protected bool Equals(RadicalSimple other)
        {
            return base.Equals(other) && this.Order == other.Order;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((RadicalSimple) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode()*397) ^ this.Order;
            }
        }
    }
}