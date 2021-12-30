class Order
{
  public string CustomerName { get; set; }
  public int productCount { get; set; }
  public void orderDetails()
  {
    System.Console.WriteLine($"{CustomerName} and he purchased {productCount}.");
  }
}