namespace Jambul.CSharp.IR
{
    public class InbuiltType : IType
    {
        public enum Types
        {
            Boolean,
            SByte,
            Byte,
            Short,
            UShort,
            Int,
            UInt,
            Long,
            ULong,
            Char,
            Float,
            Double,
            Decimal,
            String,
            VoidPtr,
            Object,
            Dynamic
        }

        public Types Type { get; }
        public bool IsPointer => Type == Types.VoidPtr;
        public bool ContainsPointer => IsPointer;
        public bool ContainsArray => false;

        public InbuiltType(Types type)
        {
            Type = type;
        }
    }
}