
namespace Jambul.CSharp.IR
{
    public class NullableType : IType
    {
        public IType BaseType { get; }
        public bool IsPointer => false;
        public bool ContainsPointer { get; }
        public bool ContainsArray { get; }

        public NullableType(IType baseType)
        {
            BaseType = baseType;
            ContainsPointer = baseType.ContainsPointer;
            ContainsArray = baseType.ContainsArray;
        }
    }
}