using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyRev.Models;

namespace VidlyRev.ViewModels
{
    public class MoviesViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }

    }
}