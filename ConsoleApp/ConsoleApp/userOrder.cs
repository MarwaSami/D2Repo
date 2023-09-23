using System.Reflection;
[assembly: AssemblyVersion("2.0.0.0")]
public class userOrder
{
	Order order = new Order ();
	public void Display()
	{
<<<<<<< HEAD
		Console.WriteLine(order.ToString());
	}
=======
        System.Console.WriteLine("V2:");
        System.Console.WriteLine (order.ToString ());
    }

>>>>>>> ffc4e4f1d9dbf80b66057cf8890d26cd60f70eac

}