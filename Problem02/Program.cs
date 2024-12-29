using System;

namespace LabWork05_Problem02
{
    public class Program
    {
        public static void Main()
        {
            // Создание списка через инициализатор коллекции
            MyList<int> myList = new MyList<int> { 1, 2, 3, 4 };

            // Добавление элемента
            myList.Add(5);

            // Получение элемента по индексу
            Console.WriteLine(myList[2]); // Вывод: 3

            // Установка значения по индексу
            myList[2] = 10;
            Console.WriteLine(myList[2]); // Вывод: 10

            // Вывод количества элементов
            Console.WriteLine(myList.Count); // Вывод: 5

            // Перебор элементов
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }

}
