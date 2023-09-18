public class Order
{
    public int OrderID { get; set; }
    public string OrderName { get; set; }
    public string OrderDate { get; set; }
    public string OrderType { get; set; }
    public User user { get; set; }
    public override string ToString()
    {
        return $"{OrderID}, {OrderName} ";
    }
}