using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnToAr
{
    internal class Trans {

        public Trans()
        {
            key = new List<char>();
            value = new List<char>();
        }
        // ----------props--------------
        //*
        public int lenght = 0;
        private const char NullChar = '\0';
        public List<char> key;
        public List<char> value;
        //*
        //------------------------------



        // ---------methods-------------
        //*
        public char getKey(int index) {
            return this.key[index];
        }
        public char getValue(int index)
        {
            return this.value[index];
        }
        public char getValueFromKey(char key)
        {
            for(int i = 0; i < this.key.Count; i++)
            {
                if (this.key[i] == key)
                {
                    return this.getValue(i);
                }
            }
            return NullChar;
        }
        public char getKeyFromValue(char value)
        {
            for (int i = 0; i < this.value.Count; i++)
            {
                if (this.value[i] == value)
                {
                    return this.getKey(i);
                }
            }
            return NullChar;
        }
        public void add(char key, char value)
        {
            lenght += 1;
            this.key.Add(key);
            this.value.Add(value);
        }
        public override string ToString()
        {
            string result = "Trans { ";
            for (int i = 0; i < lenght; i++)
            {
                result += $"{key[i]}:{value[i]}, ";
            }
            result += $"len: {lenght} }}";
            return result;
        }
        //*
        //-------------------------------
    }
}
