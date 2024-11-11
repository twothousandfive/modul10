using HOMEWORK;
using Directory = HOMEWORK.Directory;
using File = HOMEWORK.File;

public class Program
{
    public static void Main(string[] args)
    {
        /*TV tv = new TV();
        AudioSystem audioSystem = new AudioSystem();
        DVDPlayer dvdPlayer = new DVDPlayer();
        GameConsole gameConsole = new GameConsole();
        
        HomeTheaterFacade  homeTheaterFacade = new HomeTheaterFacade(tv, audioSystem, dvdPlayer, gameConsole);
        
        homeTheaterFacade.WatchMovie();
        homeTheaterFacade.EndMovie();
        homeTheaterFacade.PlayGame();*/
        
        var file1 = new File("file1.txt", 100);
        var file2 = new File("file2.txt", 200);
        var file3 = new File("file3.txt", 300);
        
        var folder1 = new Directory("folder1");
        var folder2 = new Directory("folder2");
        var folder3 = new Directory("folder3");
        
        folder1.Add(file1);
        folder1.Add(file2);
        folder2.Add(file3);
        folder3.Add(folder1);
        folder3.Add(folder2);
        
        folder3.Display();
    }
}