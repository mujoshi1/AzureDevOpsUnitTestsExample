using static System.Net.Mime.MediaTypeNames;

public static class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("hello world");
        Console.Write(addNumbers(2, 3));
        Console.WriteLine("WAITING");
        Console.WriteLine("Closing in 5 seconds...");
        System.Threading.Thread.Sleep(2000);
        System.Environment.Exit(-1);
        
    }


    public static int addNumbers(int a, int b)
    {
        return a + b;
    }
}
