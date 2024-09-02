public class Album {
    private string albumName, artistName;
    private int numOfTracks;

    public void Start() {
        Console.WriteLine("Starting the Album Program!");
        Console.WriteLine();
        ReadAlbumName();
        ReadArtistName();
        ReadTracks();
        DisplayAlbumInfo();
    }

    public void ReadTracks(){
        Console.WriteLine("How many tracks does " + albumName + " have?");
        numOfTracks = Convert.ToInt32(Console.ReadLine());
    }
    public void ReadArtistName(){
        Console.WriteLine("What is the name of the Artist or Band for " + albumName + "?");
        artistName = Console.ReadLine();
    }
    public void ReadAlbumName(){
        Console.WriteLine("What is the name of your favorite music album?");
        albumName = Console.ReadLine();
    }
    public void DisplayAlbumInfo(){
        Console.WriteLine("Album name: " + albumName);
        Console.WriteLine("Artst/Band: " + artistName);
        Console.WriteLine("Number of Tracks: " + numOfTracks);
        Console.WriteLine("Enjoy listening!");
    }
}