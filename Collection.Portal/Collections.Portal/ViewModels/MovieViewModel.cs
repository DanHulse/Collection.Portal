using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Portal.ViewModels
{
    public class MovieViewModel
    {
        [Required]
        public string Title { get; set; }

        public string TranslatedTitle { get; set; }

        public string Directors { get; set; }

        public string Producers { get; set; }

        public string Writers { get; set; }

        public string Cast { get; set; }

        public string Genres { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? RunningTime { get; set; }

        public string Certification { get; set; }

        public string Formats { get; set; }

        public bool BluRayFormat { get; set; }

        public bool DVDFormat { get; set; }

        public bool DigitalFormat { get; set; }

        public string Series { get; set; }

        public int? SeriesNumber { get; set; }

        public bool Watched { get; set; }

        public int? Rating { get; set; }

        public string PosterUrl { get; set; }
    }
}
