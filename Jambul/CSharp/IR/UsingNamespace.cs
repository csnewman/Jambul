namespace Jambul.CSharp.IR
{
    public class UsingNamespace : IUsingStatement
    {
        public string Namespace { get; }

        public UsingNamespace(string @namespace)
        {
            Namespace = @namespace;
        }

        public override string ToString()
        {
            return $"{nameof(Namespace)}: {Namespace}";
        }
    }
}
