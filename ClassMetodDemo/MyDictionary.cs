using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodDemo
{
    public class MyDictionary<T,U>
    {
        T[] key;
        U[] value;
        public MyDictionary()
        {
            key = new T[0];
            value = new U[0];
        }
        public void Add(T keyitem, U valueitem)
        {
            T[] keysecond = key;
            key = new T[key.Length + 1];
            for (int i = 0; i < keysecond.Length; i++)
            {
                key[i] = keysecond[i];
            }
            key[key.Length - 1] = keyitem;
            U[] valuesecond = value;
            value = new U[key.Length + 1];
            for (int i = 0; i < keysecond.Length; i++)
            {
                key[i] = keysecond[i];
            }
            value[value.Length - 1] = valueitem;

        }


        public int Count
        {
            get
            {
                return key.Length;
            }
        }
        public T[] DictionaryKey
        {
            get
            {
                return key;
            }
        }
        public U[] DictionaryValue
        {
            get
            {
                return value;
            }
        }
    }
}
