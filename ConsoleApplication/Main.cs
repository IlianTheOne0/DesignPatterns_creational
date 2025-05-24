namespace ClassLibrary.CreationalPatterns.Singleton;

public class Client
{
    public static void Main(string[] args)
    {
        Console.WriteLine("App: Launched with");
        Singleton singleton = Singleton.GetInstance();
        Console.WriteLine(singleton.HelloWorld());

        Console.WriteLine();

        Singleton singleton2 = Singleton.GetInstance();
        singleton2.HelloWorld();

        if (singleton == singleton2) { Console.WriteLine("App: Singleton works, both variables contain the same instance."); }
        else { Console.WriteLine("App: Singleton failed, variables contain different instances."); }
    }
}