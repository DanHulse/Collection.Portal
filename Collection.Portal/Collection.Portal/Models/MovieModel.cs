﻿using System;
using System.Collections.Generic;

namespace Collection.Portal.Models
{
    /// <summary>
    /// Model for movie data
    /// </summary>
    public class MovieModel
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
        /// Gets or sets the directors.
        /// </summary>
        public List<string> Directors { get; set; }

        /// <summary>
        /// Gets or sets the poster URL.
        /// </summary>
        public Uri PosterUrl { get; set; }
    }
}