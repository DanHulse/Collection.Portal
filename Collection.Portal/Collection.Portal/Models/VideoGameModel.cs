using System;

namespace Collection.Portal.Models
{
    /// <summary>
    /// Model for video game data
    /// </summary>
    public class VideoGameModel
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
        /// Gets or sets the box art URL.
        /// </summary>
        public Uri BoxArtUrl { get; set; }
    }
}