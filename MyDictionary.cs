using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork05_Problem03
{
    public class MyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private TKey[] keys;
        private TValue[] values;
        private int count;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
            count = 0;
        }

        // Свойство для получения общего количества элементов
        public int Count => count;

        // Метод для добавления элемента
        public void Add(TKey key, TValue value)
        {
            if (Array.IndexOf(keys, key) != -1)
            {
                throw new ArgumentException("An element with the same key already exists.");
            }

            Array.Resize(ref keys, count + 1);
            Array.Resize(ref values, count + 1);

            keys[count] = key;
            values[count] = value;
            count++;
        }

        // Индексатор для получения значения по ключу
        public TValue this[TKey key]
        {
            get
            {
                int index = Array.IndexOf(keys, key);
                if (index == -1)
                {
                    throw new KeyNotFoundException("The key was not found in the dictionary.");
                }
                return values[index];
            }
        }

        // Реализация интерфейса IEnumerable для использования foreach
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return new KeyValuePair<TKey, TValue>(keys[i], values[i]);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
