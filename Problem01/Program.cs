using System;


namespace LabWork05_Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы:");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов матрицы:");
            int cols = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите минимальное значение случайного числа:");
            int minValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите максимальное значение случайного числа:");
            int maxValue = int.Parse(Console.ReadLine());

            MyMatrix matrix = new MyMatrix(rows, cols, minValue, maxValue);
            Console.WriteLine("Сгенерированная матрица:");
            matrix.Show();

            // Тестирование метода Fill
            matrix.Fill(10, 50);
            Console.WriteLine("Матрица после повторного заполнения:");
            matrix.Show();

            // Тестирование метода ChangeSize
            Console.WriteLine("Изменение размера матрицы:");
            matrix.ChangeSize(4, 6);
            matrix.Show();

            // Тестирование метода ShowPartial
            Console.WriteLine("Частичное отображение матрицы (2-3 строки и 1-4 столбцы):");
            matrix.ShowPartial(2, 3, 1, 4);
        }
    }
}
