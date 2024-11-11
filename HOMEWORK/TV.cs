namespace HOMEWORK;

public class TV
{
    public void On(){}
    public void Off(){}
    public void SetChannel(string channel){}
}

public class AudioSystem
{
    public void On(){}
    public void Off(){}
    public void SetVolume(int volume){}
}

public class DVDPlayer
{
    public void Play(){}
    public void Pause(){}
    public void Stop(){}
}

public class GameConsole
{
    public void On(){}
    public void StartGame(){}
}

public class HomeTheaterFacade
{
    private TV tv;
    private AudioSystem audioSystem;
    private DVDPlayer dvdPlayer;
    private GameConsole gameConsole;

    public HomeTheaterFacade(TV tv, AudioSystem audioSystem, DVDPlayer dvdPlayer, GameConsole gameConsole)
    {
        this.tv = tv;
        this.audioSystem = audioSystem;
        this.dvdPlayer = dvdPlayer;
        this.gameConsole = gameConsole;
    }

    public void WatchMovie()
    {
        tv.On();
        audioSystem.On();
        audioSystem.SetVolume(5);
        dvdPlayer.Play();
    }

    public void EndMovie()
    {
        dvdPlayer.Stop();
        audioSystem.Off();
        tv.Off();
    }

    public void PlayGame()
    {
        tv.On();
        gameConsole.On();
        gameConsole.StartGame();
    }
}