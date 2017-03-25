namespace Jambul.CSharp.IR
{
    public interface IType
    {
        bool IsPointer { get; }
        bool ContainsPointer { get; }
        bool ContainsArray { get; }
    }
}