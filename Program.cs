using System;
using System.Linq.Expressions;
namespace music
{
    class Program
    {
        enum Genre
        {
            Rap,
            Country,
            Rock,
            Swing,
            Jazz
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public void setTitle(string title)
            { Title = title; }
            public void getTitle(string title)
            { Title = title; }
            public void setLength(string length)
            { Length = length; }
            public void getLength(string length)
            { Length = length; }
            public void setArtist(string artist)
            { Artist = artist; }
            public void getArtist(string artist)
            { Artist = artist; }
            public void setAlbum(string album)
            { Album = album; }
            public void getAlbum(string album)
            { Album = album; }
            public void setGenre(Genre genre)
            { Genre = genre; }
            public void getGenre(Genre genre)
            { Genre = genre; }

            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength" + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many tracks you wanna cover?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Please enter a song");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Who is your favorite Artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is your favorite album?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("How long is the Album?");
                    collection[i].setLength(Console.ReadLine());
                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("\nR- Rap\nC - Country\nT - Rock\nS - Swing\nJ - Jazz");
                    Genre tempGenre = Genre.Rap;
                    char g = char.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 'R':
                            tempGenre = Genre.Rap;
                            break;
                        case 'C':
                            tempGenre = Genre.Country;
                            break;
                        case 'T':
                            tempGenre = Genre.Rock;
                            break;
                        case 'S':
                            tempGenre = Genre.Swing;
                            break;
                        case 'J':
                            tempGenre = Genre.Jazz;
                            break;
                    }
                    collection[i].setGenre(tempGenre);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }
        }
    }
}
