class Disc
{
    public string Album {get; set;}
    public string Artista { get; set; }
    public string[] Songs { get; set; }
    public int NumTracks { get; }

    public string NombreCancion(in int song) => Songs[song];

    public Disc(in string Album, in string Artista, in string[] Songs, in int NumTracks)
    {
        this.Album = Album;
        this.Artista = Artista;
        this.Songs = Songs;
        this.NumTracks = Songs.Length;
    }

    public override string ToString()
    {
        return $"Álbum: {Album} \nArtista: {Artista}";
    }

}