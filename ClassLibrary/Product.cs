namespace ClassLibrary.CreationalPatterns.Builder.Product;

public interface IProduct<T>
{
    void AddPart(T part);
    void RemovePart(T part);
    string Show();
}

public abstract class Product<T> : IProduct<T>
{
    protected List<T> _parts = new List<T>();

    public virtual void AddPart(T part) => _parts.Add(part);
    public virtual void RemovePart(T part) => _parts.Remove(part);
    protected virtual string _Show(string? prefix = null)
    {
        string result = string.Empty;
        if (!string.IsNullOrEmpty(prefix)) { result += $"{prefix} "; }

        result += "Parts: ";
        foreach (T part in _parts) { result +=  $"{part?.ToString()} "; }
        result += ';';

        return result;
    }

    public abstract string Show();
}

public class MinimumPackage : Product<string>
{
    public override string Show() => _Show("Minimum service package");
}

public class NormalPackage : Product<string>
{
    public override string Show() => _Show("Normal service package");
}

public class MaximumPackage : Product<string>
{
    public override string Show() => _Show("Maximum service package");
}