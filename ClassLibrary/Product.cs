namespace ClassLibrary.CreationalPatterns.Singleton;

public class Singleton
{
    private static Singleton? _instance;
    private static object _lock = new object();

    private Singleton() { }

    public static Singleton GetInstance() { if (_instance == null) { lock (_lock) { _instance = new Singleton(); } } return _instance; }
    public string HelloWorld() => "Hello world!";
}