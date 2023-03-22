class DABRadio : IMedia
{

    public string MessageToDisplay 
    {
        get
        {
            string mensaje = default;
            switch (State)
            {
                case MediaState.Paused:
                    mensaje = $"PAUSED - BUFFERING FM {Frecuency} MHz";
                    break;

                case MediaState.Playing:
                    mensaje = $"HEARING... FM {Frecuency} MHz";
                    break;

                case MediaState.Stopped:
                    mensaje = $"RADIO OFF";
                    break;

            }
            return mensaje;
        }
    }
    const float SEEK_STEP = 0.5f;
    const float MAX_FRECUENCY = 108f;
    const float MIN_FRECUENCY = 87.5f;
    private float Frecuency { get; set; }
    private MediaState State  {get; set; }

    public DABRadio()
    {
        this.Frecuency = MIN_FRECUENCY;
        this.State = MediaState.Stopped;
    }
    public void Play()
    {
    if (State == MediaState.Stopped)
        {
            this.Frecuency = MIN_FRECUENCY;
            State = MediaState.Playing;
        }   
    else if (State == MediaState.Paused)
        {
            State = MediaState.Playing;
        }

        Console.WriteLine(MessageToDisplay);

    }
    public void Stop()
    {
        State = MediaState.Stopped;
        Console.WriteLine(MessageToDisplay);
    }
    public void Pause()
    {

    }
    public void Next()
    {

    }
    public void Previous()
    {

    }

}