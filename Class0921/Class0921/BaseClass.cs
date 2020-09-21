using System;

namespace Class0921
{
    public abstract class BaseClass
    {
        public String Name { get; }
        public BaseClass(string name)
        {
            this.Name = name;
        }
        public abstract string NameMetodas();
        public abstract int NameKodas(int one);
    }
}
