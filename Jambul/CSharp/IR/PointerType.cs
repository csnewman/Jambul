namespace Jambul.CSharp.IR
{
    public class PointerType : IType
    {
        public IType BaseType;
        public bool IsPointer => true;
        public bool ContainsPointer => true;
        public bool ContainsArray { get; }

        public PointerType(IType baseType)
        {
            BaseType = baseType;
            ContainsArray = baseType.ContainsArray;
        }
    }
}