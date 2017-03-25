
namespace Jambul.CSharp.IR
{
    public class TypeName
    {
        public bool HasNsAlias => NsAlias != null;
        public string NsAlias { get; }
        
        public Component[] Components { get; }

        public TypeName(string nsAlias, Component[] components)
        {
            NsAlias = nsAlias;
            Components = components;
        }

        public class Component
        {
            public string Name { get; }

            public bool HasTypes => TypeList != null && TypeList.Length > 0;
            public IType[] TypeList { get; }

            public Component(string name, IType[] typeList)
            {
                Name = name;
                TypeList = typeList;
            }
        }

    }
}
