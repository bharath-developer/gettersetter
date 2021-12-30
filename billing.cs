class Billing
{
  public string productName { get; set; }
  public int productPrice { get; set; }
  public void StudentDetails()
  {
    System.Console.WriteLine($"{productName} and it MRP is {productPrice} ");
  }
}