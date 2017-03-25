namespace Jambul.CSharp.IR
{
    public class MethodName
    {
        public string Name { get; }

        public bool HasNsAlias => NsAlias != null;
        public string NsAlias { get; }
        
        public bool HasComponents => Components != null && Components.Length > 0;
        public Component[] Components { get; }

        public MethodName(string name, string nsAlias, Component[] components)
        {
            Name = name;
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