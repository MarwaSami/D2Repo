using System.Reflection;
[assembly: AssemblyVersion("2.0.0.0")]
public class userOrder
{
	Order order = new Order ();
	public void Display()
	{
        System.Console.WriteLine("V2:");
        System.Console.WriteLine (order.ToString ());
    }


}