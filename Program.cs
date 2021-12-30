using System;

namespace getSet
{
  class Employee
  {
    public string name { get; set; }
    public string department { get; set; }
    public string printName()
    {
      return name;
    }

  }
  class Program
  {
    static void Main(string[] args)
    {
      Employee employee = new Employee();
      employee.name = Console.ReadLine();
      Console.WriteLine(employee.printName());
    }
  }

}
