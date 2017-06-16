using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class DiscJockey
    {

        SongComponent songList;

        // newSongList contains every Song, SongGroup,
        // and any Songs saved in SongGroups

        public DiscJockey(SongComponent newSongList)
        {
            songList = newSongList;
        }

        // Calls the displaySongInfo() on every Song
        // or SongGroup stored in songList

        public void getSongList()
        {
            songList.displaySongInfo();
        }
    }
}
