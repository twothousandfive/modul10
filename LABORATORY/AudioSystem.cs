namespace LABORATORY;

public class AudioSystem
{
    public void TurnOn(){}
    public void SetVolume(int level){}

    public void TurnOff(){}
}

public class VideoProjector
{
    public void TurnOn(){}
    public void SetResolution(string resolution){}
    public void TurnOff(){}
}

public class LightingSystem
{
    public void TurnOn(){}
    public void SetBrightness(int level){}
    public void TurnOff(){}
}

public class HomeTheaterFacade
{
    private AudioSystem _audioSystem;
    private VideoProjector _videoProjector;
    private LightingSystem _lightingSystem;

    public HomeTheaterFacade(AudioSystem audioSystem, VideoProjector videoProjector, LightingSystem lightingSystem)
    {
        _audioSystem = audioSystem;
        _videoProjector = videoProjector;
        _lightingSystem = lightingSystem;
    }

    public void StartMovie()
    {
        _lightingSystem.TurnOn();
        _lightingSystem.SetBrightness(5);
        _audioSystem.TurnOn();
        _audioSystem.SetVolume(10);
        _videoProjector.TurnOn();
        _videoProjector.SetResolution("1280x720");
    }

    public void StopMovie()
    {
        _videoProjector.TurnOff();
        _audioSystem.TurnOff();
        _lightingSystem.TurnOff();
    }
}