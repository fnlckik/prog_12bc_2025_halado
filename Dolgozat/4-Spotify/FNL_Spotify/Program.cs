using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Spotify
{
    internal class Program
    {
        static List<Song> SeedData()
        {
            return new List<Song>
            {
                new Song("It’s Beginning to Look a Lot Like Christmas", "Michael Bublé", 207, 1951, 9),
                new Song("Jingle Bells", "James Lord Pierpont", 185, 1857, 7),
                new Song("White Christmas", "Bing Crosby", 233, 1942, 9),
                new Song("Feliz Navidad", "José Feliciano", 182, 1970, 8),
                new Song("Last Christmas", "Wham!", 262, 1984, 9),
                new Song("Let It Snow! Let It Snow! Let It Snow!", "Frank Sinatra", 155, 1945, 7),
                new Song("All I Want for Christmas Is You", "Mariah Carey", 241, 1994, 10),
                new Song("Santa Claus Is Coming to Town", "Bruce Springsteen", 273, 1934, 6),
                new Song("Have Yourself a Merry Little Christmas", "Judy Garland", 170, 1944, 8),
                new Song("Silent Night", "Franz Xaver Gruber", 215, 1818, 10),
                new Song("Do They Know It’s Christmas?", "Band Aid", 345, 1984, 7),
                new Song("Wonderful Christmastime", "Paul McCartney", 227, 1979, 6),
                new Song("Driving Home for Christmas", "Chris Rea", 239, 1988, 8),
                new Song("Rockin’ Around the Christmas Tree", "Brenda Lee", 126, 1958, 10),
                new Song("Happy Xmas (War Is Over)", "John Lennon", 214, 1971, 9),
                new Song("Mary’s Boy Child", "Harry Belafonte", 190, 1956, 7),
                new Song("O Come All Ye Faithful", "Traditional", 240, 1750, 6),
                new Song("Blue Christmas", "Elvis Presley", 127, 1948, 8),
                new Song("Holly Jolly Christmas", "Burl Ives", 135, 1964, 7),
                new Song("Christmas Time (Is Here Again)", "The Beatles", 162, 1967, 6)
            };
        }

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            List<Song> songs = SeedData();
            Print("Zenék:", songs);
            Console.Clear();

            // Feladatok

            // A
            var a = songs.Average(x => x.Rating);
            Console.WriteLine("\nA: " + a);

            // B
            var b = songs.Where(x => x.Year < 1900).Select(x => x.Title);
            Print("\nB:", b);

            // C
            try
            {
                var c = songs.First(x => x.Duration > 240 && x.Rating > 7);
                Console.WriteLine("\nC: " + c);
            }
            catch (Exception)
            {
                var c = "Nincs ilyen.";
                Console.WriteLine("\nC: " + c);
            }

            // D
            var d = songs.Last(x => x.Year == songs.Select(y => y.Year).Max());
            Console.WriteLine("\nD: " + d);

            // E
            var e = songs.OrderByDescending(x => x.Rating).ThenBy(x => x.Duration).Take(4);
            Print("\nE:", e);

            // F
            // x.Title.Split().Any(w => w == "Christmas")
            var f = songs.Where(x => x.Title.Contains("Christmas")).Select(x => new { x.Title, x.Duration });
            Print("\nF:", f);

            // G
            var g = songs.Select(x => x.Rating).Distinct().Count();
            Console.WriteLine("\nG: " + g);

            // H
            var h = Math.Sqrt(songs.Select(x => Math.Pow(x.Rating - a, 2)).Average());
            Console.WriteLine("\nH: " + h);

            // Bonusz
            var xy = songs.Select(x => new { x.Title, x.Rating, Order = songs.Count(y => y.Rating > x.Rating) + 1 }).OrderBy(x => x.Order);
            Print("\nXY:", xy);
        }
    }
}
