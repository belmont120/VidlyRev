using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyRev.Models;

namespace VidlyRev.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }

        public string Title { get { return Movie.Id == 0 ? "New Movie" : "Edit Movie"; } }
    }
}