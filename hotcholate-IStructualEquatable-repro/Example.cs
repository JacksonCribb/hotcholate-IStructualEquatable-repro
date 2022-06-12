using System.Collections;

namespace hotcholate_IStructualEquatable_repro;

public class Example : IStructuralEquatable
{
    public string? Name { get; set; } = null;

    public bool Equals(object? other, IEqualityComparer comparer)
    {
        return false;
    }

    public int GetHashCode(IEqualityComparer comparer)
    {
        return 0;
    }
}
