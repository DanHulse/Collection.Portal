using System;
using System.Collections.Generic;

namespace Collection.Portal.Models
{
    /// <summary>
    /// Model for book data
    /// </summary>
    public class BookModel
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
        /// Gets or sets the authors.
        /// </summary>
        public List<string> Authors { get; set; }

        /// <summary>
        /// Gets or sets the cover URL.
        /// </summary>
        public Uri CoverUrl { get; set; }
    }
}