namespace ClassLibrary.CreationalPatterns.Prototype;
using ClassLibrary.CreationalPatterns.Prototype.NPrototype;

public class Client
{
    public static void ClientMethod(Object _object)
    {
        Console.WriteLine($"Coords: ({_object.x}; {_object.y}; {_object.z})");
        Console.WriteLine($"Sizes: ({_object.width}; {_object.height}; {_object.depth})");
    }

    public static void Main(string[] args)
    {
        Object _object1 = new Object(-1, -1, -1, 2, 2, 2);
        Console.WriteLine("App: Launched with the Object.");
        ClientMethod(_object1);

        Console.WriteLine();

        Object _object2 = (Object)_object1.Clone();
        Console.WriteLine("App: Launched with the Object2.");
        ClientMethod(_object2);
    }
}