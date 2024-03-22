using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieModels
{
    public class Movie
    {
        public int MovID { get; set; }
        public string MovName { get; set; }
        public int MovYear { get; set; }
        public string MovDesc { get; set; }
        public string MovGenre { get; set; }
        public string MovImg { get; set; }
        public int MovPrice { get; set; }

    }
}
