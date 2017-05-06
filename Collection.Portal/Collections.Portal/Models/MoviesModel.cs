using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Portal.Models
{
    public class MoviesModel
    {
        public string Title { get; set; }

        public string TranslatedTitle { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? RunningTime { get; set; }

        public string Certification { get; set; }

        public IEnumerable<string> Formats { get; set; }

        public string Series { get; set; }

        public int? SeriesNumber { get; set; }

        public bool Watched { get; set; }

        public int? Rating { get; set; }

        public string PosterUrl { get; set; }

        public List<string> Directors { get; set; }

        public List<string> Producers { get; set; }

        public List<string> Writers{ get; set; }

        public List<string> Cast { get; set; }

        public List<string> Genres { get; set; }
    }
}
