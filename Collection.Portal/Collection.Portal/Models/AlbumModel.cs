using System;

namespace Collection.Portal.Models
{
    /// <summary>
    /// Model for album model
    /// </summary>
    public class AlbumModel
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the translated title.
        /// </summary>
        public string TranslatedTitle { get; set; }

        /// <summary>
        /// Gets or sets the album artist.
        /// </summary>
        public string AlbumArtist { get; set; }

        /// <summary>
        /// Gets or sets the album cover URL.
        /// </summary>
        public Uri AlbumCoverUrl { get; set; }
    }
}