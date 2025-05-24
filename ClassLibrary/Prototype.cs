namespace ClassLibrary.CreationalPatterns.Prototype.NPrototype;

public interface IPrototype
{
    IPrototype Clone();
}

public abstract class Prototype : IPrototype
{
    public abstract IPrototype Clone();
}

public class Object : Prototype
{
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }

    public int width { get; set; }
    public int height { get; set; }
    public int depth { get; set; }

    public Object(int x, int y, int z, int width, int height, int depth)
    {
        this.x = x;
        this.y = y;
        this.z = z;

        this.width = width;
        this.height = height;
        this.depth = depth;
    }

    public override Prototype Clone() => new Object(x, y, z, width, height, depth);
}