namespace ClassLibrary.CreationalPatterns.Builder;
using ClassLibrary.CreationalPatterns.Builder.Builder;
using ClassLibrary.CreationalPatterns.Builder.NDirector;

public class Client
{
    public static void Main(string[] args)
    {
        var minimumPackageBuilder = new MinimumPackageBuilder();
        Director director = new Director(minimumPackageBuilder);
        Console.WriteLine("App: Launched with the MinimumPackageBuilder.");
        Console.WriteLine(director.CreateMinimumPackage());
        Console.WriteLine();
        Console.WriteLine("App: Deleting the MinimumPackageBuilder.");
        Console.WriteLine(director.DeleteMinimumPackage());
        
        Console.WriteLine(); Console.WriteLine();

        var normalPackageBuilder = new NormalPackageBuilder();
        director = new Director(normalPackageBuilder);
        Console.WriteLine("App: Launched with the NormalPackageBuilder.");
        Console.WriteLine(director.CreateNormalPackage());
        Console.WriteLine();
        Console.WriteLine("App: Deleting the NormalPackageBuilder.");
        Console.WriteLine(director.DeleteNormalPackage());

        Console.WriteLine(); Console.WriteLine();

        var maximumPackageBuilder = new MaximumPackageBuilder();
        director = new Director(maximumPackageBuilder);
        Console.WriteLine("App: Launched with the MaximumPackageBuilder.");
        Console.WriteLine(director.CreateMaximumPackage());
        Console.WriteLine();
        Console.WriteLine("App: Deleting the MaximumPackageBuilder.");
        Console.WriteLine(director.DeleteMaximumPackage());
    }
}