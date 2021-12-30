class Employee
{
  public string EmployeeId { get; set; }
  public string EmployeeDepartment { get; set; }
  public void EmployeeDetails()
  {
    System.Console.WriteLine($"{EmployeeId} and he is working in {EmployeeDepartment} department.");
  }

}