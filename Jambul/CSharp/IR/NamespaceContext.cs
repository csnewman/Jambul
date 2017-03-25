using System;

namespace Jambul.CSharp.IR
{
    public class NamespaceContext
    {
        public string Name { get; }

        public IUsingStatement[] UsingStatements { get; }

        public NamespaceContext(string name, IUsingStatement[] @using)
        {
            Name = name;
            UsingStatements = @using;
        }

        public NamespaceContext GetChildContext(string name, IUsingStatement[] @using)
        {
            string newName = (Name != null ? Name + "." : "") + name;

            IUsingStatement[] statements = new IUsingStatement[UsingStatements.Length + @using.Length];
            Array.Copy(UsingStatements, 0, statements, 0, UsingStatements.Length);
            Array.Copy(@using, 0, statements, UsingStatements.Length, @using.Length);

            return new NamespaceContext(newName, statements);
        }
    }
}