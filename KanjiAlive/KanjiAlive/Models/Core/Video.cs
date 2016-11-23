namespace KanjiAlive.Models.Core
{
    /// <summary>
    ///     Video hyperlinks.
    /// </summary>
    public class Video
    {
        /// <summary>
        ///     Hyperlink to the poster image.
        /// </summary>
        public string Poster { get; set; }

        /// <summary>
        ///     Hyperlink to the video in MP4 format.
        /// </summary>
        public string Mp4 { get; set; }

        /// <summary>
        ///     Hyperlink to the video in WebM format.
        /// </summary>
        public string Webm { get; set; }

        protected bool Equals(Video other)
        {
            return string.Equals(this.Poster, other.Poster) && string.Equals(this.Mp4, other.Mp4) && string.Equals(this.Webm, other.Webm);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return this.Equals((Video) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = this.Poster != null ? this.Poster.GetHashCode() : 0;
                hashCode = (hashCode*397) ^ (this.Mp4 != null ? this.Mp4.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (this.Webm != null ? this.Webm.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}