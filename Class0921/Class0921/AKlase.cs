using System.Collections.Generic;

namespace Class0921
{
    public class AKlase : BaseClass
    {
        public AKlase(string name) : base(name)
        {
        }

        public override int NameKodas(int num)
        {
            int newName = 0;
            
            foreach (var item in Name)
            {
                newName += (int)item * num;
            }
            return newName;
        }

        public override string NameMetodas()
        {
            string newName = "";
            List<char> Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            foreach (var item in Name)
            {
                if (Vowels.Contains(item))
                {
                    newName += (int)item;
                }
                else
                {
                    newName += item;
                }
            }
                return newName;
        }
    }
}
