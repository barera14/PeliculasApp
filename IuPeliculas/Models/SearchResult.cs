using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IuPeliculas.Models
{
    public class searchResult
    {
        public List<Movies> Search { get; set; }
        public string totalResults { get; set; }
        public bool Response { get; set; }
    }
}
