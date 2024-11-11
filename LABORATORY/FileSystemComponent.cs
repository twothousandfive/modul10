namespace LABORATORY;

public abstract class FileSystemComponent
{
    protected string Name;

    public FileSystemComponent(string name)
    {
        Name = name;
    }
    public abstract void Display(int depth);
    public virtual void Add(FileSystemComponent component){}
    public virtual void Remove(FileSystemComponent component){}
}

public class File : FileSystemComponent
{
    public File(string name) : base(name) { }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + " File: " + Name);
    }
}

public class Directory : FileSystemComponent
{
    private List<FileSystemComponent> components = new();
    public Directory(string name) : base(name) { }

    public override void Add(FileSystemComponent component)
    {
        components.Add(component);
    }

    public override void Remove(FileSystemComponent component)
    {
        components.Remove(component);
    }

    public override FileSystemComponent GetComponent(string index)
    {
        return components[index];
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + " Directory: " + Name);
        foreach (var component in components)
        {
            component.Display(depth + 2);
        }
    }
}