
namespace Dictionary
{
    internal class MyDictionary<T1, T2>
    {
        private T1[] keys { get; set; }
        private T1[] tempKeys { get; set; }
        private T2[] values { get; set; }
        private T2[] tempValues { get; set; }

        public MyDictionary()
        {
            keys = new T1[0];
            values = new T2[0];
        }


        public void Add(T1 key, T2 value)
        {
            tempKeys = keys;
            tempValues = values;

            if (isFound(keys, key) == -1)
            {
                keys = new T1[tempKeys.Length + 1];
                values = new T2[tempValues.Length + 1];

                for (int i = 0; i < tempKeys.Length; i++)
                {
                    keys[i] = tempKeys[i];
                    values[i] = tempValues[i];

                }

                keys[keys.Length - 1] = key;
                values[values.Length - 1] = value;

            }
            else
            {
                int index = isFound(keys, key);

                values[index] = value;
            }

        }



        private int isFound(T1[] keys, T1 key){  //eklenmek istenen anahtar sözlükte var mı

            int index = -1;

            for (int i = 0; i < keys.Length; i++)
            {
                if (keys[i].Equals(key))
                {
                    index = i;
                }
            }
            return index;
            
        }

        public void Listele(MyDictionary<T1,T2> myDictionary)
        {
            for (int i = 0; i < myDictionary.keys.Length; i++)
            {
                Console.WriteLine("Key: " + myDictionary.keys[i] + ", Value: " + myDictionary.values[i]);
            }
        }
    }
}
