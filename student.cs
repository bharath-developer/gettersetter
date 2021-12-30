class student
{
  public string stuentName { get; set; }
  public int StudentClass { get; set; }
  public void StudentDetails()
  {
    System.Console.WriteLine($"{stuentName} and he is studying in {StudentClass} standard.");
  }
}