using System;

namespace Jambul.CSharp.IR
{
    [Flags]
    public enum Modifiers
    {
        New = 1 << 0,
        Public = 1 << 1,
        Protected = 1 << 2,
        Internal = 1 << 3,
        Private = 1 << 4,
        ReadOnly = 1 << 5,
        Volatile = 1 << 6,
        Virtual = 1 << 7,
        Sealed = 1 << 8,
        Override = 1 << 9,
        Abstract = 1 << 10,
        Static = 1 << 11,
        Unsafe = 1 << 12,
        Extern = 1 << 13,
        Partial = 1 << 14,
        Async = 1 << 15
    }
}