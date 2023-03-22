class DABRadioCD : IMedia
{

    IMedia ActiveDevice { get; set; }
    Disc InsertCD { get; set; }
    DABRadio radio;
    CDPlayer reproductor;
    public string MessageToDisplay { get; }

    public DABRadioCD()
    {
        this.radio = new DABRadio();
        this.reproductor = new CDPlayer();
    }


    public void ExtractCD()
    {

        ActiveDevice = radio;
    }

    public void SwitchMode()
    {
        if (ActiveDevice is CDPlayer)
        {
            ActiveDevice = radio;
        }

        else ActiveDevice = reproductor;
    }
    public void Play()
    {

    }
    public void Stop()
    {

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