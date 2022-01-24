using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class MyDictionary<T, U>
    {
        T[] itemsT;
        U[] itemsU;

        public MyDictionary()
        {
            itemsT = new T[0];
            itemsU = new U[0];
        }
        public void Add(T itemT, U itemU)
        {
            T[] tempArrayT = itemsT;
            itemsT = new T[itemsT.Length + 1];

            for (int i = 0; i < tempArrayT.Length; i++)
            {
                itemsT[i] = tempArrayT[i];
            }

            itemsT[itemsT.Length - 1] = itemT;

            U[] tempArrayU = itemsU;
            itemsU = new U[itemsU.Length + 1];

            for (int i = 0; i < tempArrayU.Length; i++)
            {
                itemsU[i] = tempArrayU[i];
            }

            itemsU[itemsU.Length - 1] = itemU;
        }
    }
}
