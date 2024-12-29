using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork05_Problem02
{
    public class MyList<T> : IEnumerable<T>
    {
        private T[] _items;
        private int _count;

        // Конструктор
        public MyList()
        {
            _items = new T[4]; // Начальная емкость
            _count = 0;
        }

        // Метод добавления элемента
        public void Add(T item)
        {
            if (_count == _items.Length)
            {
                Resize();
            }
            _items[_count++] = item;
        }

        // Индексатор для доступа к элементам
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException("Индекс вне диапазона.");
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _count)
                    throw new IndexOutOfRangeException("Индекс вне диапазона.");
                _items[index] = value;
            }
        }

        // Свойство получения общего количества элементов
        public int Count => _count;

        // Метод увеличения емкости массива
        private void Resize()
        {
            int newCapacity = _items.Length * 2;
            T[] newArray = new T[newCapacity];
            Array.Copy(_items, newArray, _items.Length);
            _items = newArray;
        }

        // Реализация интерфейса IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Поддержка инициализатора коллекции
        public MyList(IEnumerable<T> collection)
        {
            if (collection == null)
                throw new ArgumentNullException(nameof(collection));

            _items = new T[4];
            _count = 0;

            foreach (var item in collection)
            {
                Add(item);
            }
        }
    }
}
