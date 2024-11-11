namespace HOMEWORK;

public abstract class FileSystemComponent
{
    protected string Name;

    public FileSystemComponent(string name)
    {
        Name = name;
    }
    public abstract void Display(int indent = 0);
    public abstract int GetSize();
}

public class File : FileSystemComponent
{
    private int Size;

    public File(string name, int size) : base(name)
    {
        Size = size;
    }

    public override void Display(int indent = 0)
    {
        Console.WriteLine($"{new string(' ', indent)}- File: {Name}, Size: {Size}KB");
    }
    public override int GetSize(){return Size;}
}

public class Directory : FileSystemComponent
{
    private List<FileSystemComponent> _components = new List<FileSystemComponent>();
    public Directory(string name) : base(name){}

    public void Add(FileSystemComponent component)
    {
        _components.Add(component);
    }

    public void Remove(FileSystemComponent component)
    {
        _components.Remove(component);
    }

    public override void Display(int indent = 0)
    {
        Console.WriteLine($"{new string(' ', indent)}+ Directory: {Name}");
        foreach (var component in _components)
        {
            component.Display(indent + 2);
        }
    }
    public override int GetSize()
    {
        int totalSize = 0;
        foreach (var component in _components)
        {
            totalSize += component.GetSize();
        }
        return totalSize;
    }
}