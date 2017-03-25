namespace Jambul.CSharp.IR
{
    public class NamedType : IType
    {
        public TypeName Type { get; }
        public bool IsPointer => false;
        public bool ContainsPointer => false;
        public bool ContainsArray => false;

        public NamedType(TypeName type)
        {
            Type = type;
        }
    }
}
