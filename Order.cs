public class Order
{
    public int OrderNumber;
    public string ProductName = "";
    public int Quantity;
    public decimal TotalAmount;

    public Order(int orderNumber, string productName, int productQuantity, decimal orderAmount)
    {
        OrderNumber = orderNumber;
        ProductName = productName;
        Quantity = productQuantity;
        TotalAmount = orderAmount;
    }

    public Order(string productName, int productQuantity)
    {
        ProductName = productName;
        Quantity = productQuantity;
    }

    public Order(string productName, decimal orderAmount)
    {
        ProductName = productName;
        TotalAmount = orderAmount;
    }

    public void DisplayInfo()
    {
        System.Console.WriteLine($"OrderNumber: {OrderNumber}");
        System.Console.WriteLine($"ProductName: {ProductName}");
        System.Console.WriteLine($"Quantity: {Quantity}");
        System.Console.WriteLine($"TotalAmount: {TotalAmount.ToString("0.0", System.Globalization.CultureInfo.InvariantCulture)}");
        System.Console.WriteLine();
    }
}