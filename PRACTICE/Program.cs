using PRACTICE;

class Programm
{
    public static void Main(string[] args)
    {
        //HotelFacade facade = new HotelFacade();
        //facade.Reserve();
        
        Department department1 = new Department();
        department1.Name = "Test1";
        Department department2 = new Department();
        department2.Name = "Test2";
        
        Employee employee1 = new Employee();
        employee1.Name = "Name1";
        employee1.Salary = 1000;
        Employee employee2 = new Employee();
        employee2.Name = "Name2";
        employee2.Salary = 500;
        
        department1.add(employee1);
        
    }
}