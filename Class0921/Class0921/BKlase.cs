using System.Collections.Generic;

namespace Class0921
{
    public class BKlase : BaseClass, ZodisKitaip
    {
        public BKlase(string name) : base(name)
        {
        }

        public override int NameKodas(int one)
        {
            int newName = 0;

            foreach (var item in Name)
            {
                newName -= (int)item * one;
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

        public string ZodisBeBalsiu()
        {
            string newName = "";
            List<char> Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            foreach (var item in Name)
            {
                if (!Vowels.Contains(item))
                {
                    newName += item;
                }
            }
            return newName;
        }

        public string ZodisBePriebalsiu()
        {
            string newName = "";
            List<char> Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            foreach (var item in Name)
            {
                if (Vowels.Contains(item))
                {
                    newName += item;
                }
            }
            return newName;
        }

        public string ZodisSuPakeistomisBalsemis(char one)
        {
            string newName = "";
            List<char> Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            foreach (var item in Name)
            {
                if (Vowels.Contains(item))
                {
                    newName += one;
                }
                else
                {
                    newName += item;
                }
            }
            return newName;
        }

        public string ZodisSuPakeistomisPriebalsemis(int one)
        {
            string newName = "";
            List<char> Vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            foreach (var item in Name)
            {
                if (Vowels.Contains(item))
                {
                    newName += one.ToString();
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
