namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     Hyperlinks to audio files in various formats.
    /// </summary>
    public class Audio
    {
        /// <summary>
        ///     Hyperlink to audio file in Opus format.
        /// </summary>
        public string Opus { get; set; }

        /// <summary>
        ///     Hyperlink to audio file in AAC format.
        /// </summary>
        public string Aac { get; set; }

        /// <summary>
        ///     Hyperlink to audio file in Ogg format.
        /// </summary>
        public string Ogg { get; set; }

        /// <summary>
        ///     Hyperlink to audio file in MP3 format.
        /// </summary>
        public string Mp3 { get; set; }

        protected bool Equals(Audio other)
        {
            return string.Equals(this.Opus, other.Opus) && string.Equals(this.Aac, other.Aac) && string.Equals(this.Ogg, other.Ogg) && string.Equals(this.Mp3, other.Mp3);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((Audio) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = this.Opus != null ? this.Opus.GetHashCode() : 0;
                hashCode = (hashCode*397) ^ (this.Aac != null ? this.Aac.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Ogg != null ? this.Ogg.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Mp3 != null ? this.Mp3.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}