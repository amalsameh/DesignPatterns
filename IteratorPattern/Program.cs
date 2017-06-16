using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SongsOfThe70s songs70s = new SongsOfThe70s();
            SongsOfThe80s songs80s = new SongsOfThe80s();
            SongsOfThe90s songs90s = new SongsOfThe90s();

            DiscJockey madMike = new DiscJockey(songs70s, songs80s, songs90s);

            // madMike.showTheSongs();

            madMike.showTheSongs2();
        }
    }
}
