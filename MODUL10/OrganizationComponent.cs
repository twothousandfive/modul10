namespace MODUL10;

public abstract class OrganizationComponent
{
    public String Name;
    public double Salary;
    public virtual void add(OrganizationComponent component){}
    public virtual void remove(OrganizationComponent component){}
}

public class Employee : OrganizationComponent
{
    
}

public class Department : OrganizationComponent
{
    List<OrganizationComponent> components;

    public Department()
    {
        components = new List<OrganizationComponent>();
    }

    public override void add(OrganizationComponent component)
    {
        components.Add(component);
    }

    public override void remove(OrganizationComponent component)
    {
        components.Remove(component);
    }
}