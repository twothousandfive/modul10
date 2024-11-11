using LABORATORY;
using Directory = System.IO.Directory;
using File = System.IO.File;

class Program
{
    public static void Main(string[] args)
    {
        AudioSystem audioSystem = new AudioSystem();
        VideoProjector videoProjector = new VideoProjector();
        LightingSystem lightingSystem = new LightingSystem();

        HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(audioSystem, videoProjector, lightingSystem);
        homeTheaterFacade.StartMovie();
        homeTheaterFacade.StopMovie();
        //////////////////////////////////////////////////////

        Directory root = new Directory("Root");
        File file1 = new File("File1.txt");
        File file2 = new File("File2.txt");
        
        Directory subDir = new Directory("SubDir");
        File subFile1 = new File("SubFile1.txt");

        root.Add(file1);
        root.Add(file2);
        
        subDir.Add(subFile);
        root.Add(subDir);

        root.Display(1);
    }
}