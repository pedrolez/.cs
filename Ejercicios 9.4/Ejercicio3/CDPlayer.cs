class CDPlayer : IMedia
{

    public Disc disco {get; set;}
        public string MessageToDisplay 
    {
        get
        {
            string mensaje = default;
            switch (State)
            {
                case MediaState.Paused:
                      mensaje = $"PAUSED... Álbum: {disco.Album}  Artista: {disco.Artista}  Track {Track} - {disco.Songs[Track]}";
                    break;

                case MediaState.Playing:
                    mensaje = $"PLAYING... Álbum: {disco.Album} Artista: {disco.Artista}";
                    break;

                case MediaState.Stopped:
                    mensaje = $"RADIO OFF";
                    break;

                default:
                    mensaje = "NO DISC";
                break;

            }
            return mensaje;
        }
    }

    private ushort Track { get; set; }
    private MediaState State { get; set; }

    public void Play()
    {
        if (State == MediaState.Paused)
        {
            State = MediaState.Playing;
            Console.WriteLine(MessageToDisplay);
        }
        else if (State == MediaState.Stopped)
        {
            State = MediaState.Playing;
            Track = 1;
        }
    }

    public void Stop() 
    { 
        State = MediaState.Stopped;
        Console.WriteLine(MessageToDisplay);
    }

    public void Pause() 
    { 
        if (State == MediaState.Paused)
        {
            State = MediaState.Playing;
            Console.WriteLine(MessageToDisplay);
        }

        else
        {
            State = MediaState.Paused;
            Console.WriteLine(MessageToDisplay);
        }
    }

    public void Next() 
    {
        Track ++;
        Console.WriteLine(MessageToDisplay);
    }

    public void Previous() 
    {
        Track --;
        Console.WriteLine(MessageToDisplay);
    }

    public void InsertMedia(Disc media)
    {
        disco = media;
    }
}
