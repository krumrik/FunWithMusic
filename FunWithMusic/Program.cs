using System;

public class Program
{
    public enum MusicGenre
    {
        Rock,
        Rap,
        RnB,
        Indie,
        Jazz
    }

    public struct Music
    {
        public string Title;
        public string Artist;
        public string Album;
        public double Length;
        public MusicGenre Genre;

        public Music(string title, string artist, string album, double length, MusicGenre genre)
        {
            Title = title;
            Artist = artist;
            Album = album;
            Length = length;
            Genre = genre;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public void SetLength(double length)
        {
            Length = length;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Artist: {Artist}");
            Console.WriteLine($"Album: {Album}");
            Console.WriteLine($"Length: {Length} minutes");
            Console.WriteLine($"Genre: {Genre}");
        }
    }

    public static void Main()
    {
        Console.Write("What is the name of the song? ");
        string tempTitle = Console.ReadLine();

        Console.Write("Who is the artist? ");
        string tempArtist = Console.ReadLine();

        Console.Write("What album is it on? ");
        string tempAlbum = Console.ReadLine();

        Console.Write("Enter the length of the song (in minutes): ");
        double tempLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the genre of the song?");
        foreach (MusicGenre genre in Enum.GetValues(typeof(MusicGenre)))
        {
            Console.WriteLine($"{(int)genre}. {genre}");
        }
        Console.Write("Enter Genre (choose the corresponding number): ");
        int genreChoice = Convert.ToInt32(Console.ReadLine());
        MusicGenre tempGenre = (MusicGenre)genreChoice;

        Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);

        Music moreMusic = music;

        Console.Write("\nWhat is the next song on the album? ");
        moreMusic.SetTitle(Console.ReadLine());

        Console.Write("Enter the length of the song (in minutes): ");
        moreMusic.SetLength(Convert.ToDouble(Console.ReadLine()));

        Console.WriteLine("\nFirst Song Information:");
        music.Display();

        Console.WriteLine("\nSecond Song Information:");
        moreMusic.Display();
    }
}
