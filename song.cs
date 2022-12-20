using System;
using System.Collections.Generic;
public class Song
{
    private string name;
    public Song NextSong { get; set; }
 
    public Song(string name)
    {
        this.name = name;
    }
    
    // Write a method that detecs whether a playlist has repeating elements
    public bool IsRepeatingPlaylist()
    {
        var currentSong = this;
        var visitedSongs = new HashSet<Song>();
        while (currentSong != null)
        {
            if (visitedSongs.Contains(currentSong))
            {
                return true;
            }
            visitedSongs.Add(currentSong);
            currentSong = currentSong.NextSong;
        }
        return false;
    }
    
    //public static void Main(string[] args)
    //{
    //    Song first = new Song("Hello");
    //    Song second = new Song("Eye of the tiger");
    
    //    first.NextSong = second;
    //    second.NextSong = first;
    
    //    Console.WriteLine(first.IsRepeatingPlaylist());
    //}
}