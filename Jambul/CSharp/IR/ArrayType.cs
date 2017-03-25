namespace Jambul.CSharp.IR
{
    public class ArrayType : IType
    {
        public IType BaseType { get; }
        public int Order { get; }
        public bool IsPointer => false;
        public bool ContainsPointer { get; }
        public bool ContainsArray => true;

        public ArrayType(IType baseType, int order)
        {
            BaseType = baseType;
            ContainsPointer = baseType.ContainsPointer;
            Order = order;
        }
    }
}