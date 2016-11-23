namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     Index information for a kanji character in common references.
    /// </summary>
    public class References
    {
        /// <summary>
        ///     Grade level.
        /// </summary>
        public int? Grade { get; set; }

        /// <summary>
        ///     Kodansha index.
        /// </summary>
        public string Kodansha { get; set; }

        /// <summary>
        ///     Classic Nelson dictionary index.
        /// </summary>
        public string ClassicNelson { get; set; }

        protected bool Equals(References other)
        {
            return this.Grade == other.Grade && string.Equals(this.Kodansha, other.Kodansha) && string.Equals(this.ClassicNelson, other.ClassicNelson);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((References) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = this.Grade.GetHashCode();
                hashCode = (hashCode*397) ^ (this.Kodansha != null ? this.Kodansha.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.ClassicNelson != null ? this.ClassicNelson.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}