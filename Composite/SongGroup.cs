using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class SongGroup : SongComponent
    {

        // Contains any Songs or SongGroups that are added
        // to this ArrayList

        ArrayList songComponents = new ArrayList();

    String groupName;
    String groupDescription;

    public SongGroup(String newGroupName, String newGroupDescription)
    {
        groupName = newGroupName;
        groupDescription = newGroupDescription;
    }

    public String getGroupName() { return groupName; }
    public String getGroupDescription() { return groupDescription; }

    public void add(SongComponent newSongComponent)
    {
        songComponents.Add(newSongComponent);
    }

    public void remove(SongComponent newSongComponent)
    {
        songComponents.Remove(newSongComponent);
    }

    public SongComponent getComponent(int componentIndex)
    {
        return (SongComponent)songComponents[componentIndex];
    }

    public void displaySongInfo()
    {
        Console.WriteLine(getGroupName() + " " +
                getGroupDescription() + "\n");

            // Cycles through and prints any Songs or SongGroups added
            // to this SongGroups ArrayList songComponents

            IEnumerator songIterator = songComponents.GetEnumerator();
                while (songIterator.MoveNext())
        {
            SongComponent songInfo = (SongComponent)songIterator.Current;
            songInfo.displaySongInfo();
        }
    }
}
}
