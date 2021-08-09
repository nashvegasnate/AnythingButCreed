using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed

    //1. Define a class called `Song` that has a string property `Artist` and a string property `Name`. Both properties should be required in order to construct an instance of `Song`
    //2. Define a List, named `goodSongs`, that will hold instances of `Song`.
    //3. Define a List, named `allSongs`, that contains 12 instances of `Song`.

    //   Make sure that some of the songs are from the band Creed.If you're not familiar with the band, consider yourself lucky and make up some songs. It's not worth googling.

    //4. Once the set is populated with 12 instances of song, use Linq to filter the `allSongs` list for songs where the artist is **not** Creed. Set `goodSongs` equal to the filtered result.
    //5. Loop to print out all the good songs:
    //    Queen : Don't Stop Me Now
    //    Dolly Parton : 9 to 5
    
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> goodSongs = new List<string>();


            var allSongs = new List<Song>
            {
               new Song("Robert Palmer", "Spanish Moon"),
               new Song("Creed", "A Crappy Creed Song"),
               new Song("Joe Jackson", "Look Sharp"),
               new Song("Bill Withers", "Grandma's Hands"),
               new Song("Ohio Players", "Fire"),
               new Song("Thin Lizzy", "Rosalie"),
               new Song("Creed", "Yet Another Crappy Creed Song"),
               new Song("Elvis Costello", "Beyond Belief"),
               new Song("James Brown","Mother Popcorn"),
               new Song("Prince", "Cream"),
               new Song("The Damned", "Brand New Rose"),
               new Song("The Specials", "Concrete Jungle"),
            };

            var allButCreedSongs = allSongs.Where(song => song.Artist != "Creed");

            foreach (var song in allButCreedSongs)
            {
                Console.WriteLine($"{song.Artist}: {song.Name}");
            }


        }
    }
}
