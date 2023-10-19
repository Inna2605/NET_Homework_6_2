//Створіть інтерфейс ICalc. У ньому мають бути два методи:
//■ int Less(int valueToCompare) — повертає кількість менших значень, ніж valueToCompare;
//■ int Greater(intvalueToCompare) — повертає кількість більших значень, ніж valueToCompare.
//Клас, створений раніше у практичному завданні Array, має імплементувати інтерфейс ICalc.
//Метод Less — повертає кількість елементів масиву менших, ніж valueToCompare.
//Метод Greater — повертає кількість елементів масиву більших, ніж valueToCompare.
//Напишіть код для тестування отриманої функціональності.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть розмір масиву: ");
            int size = Convert.ToInt32(Console.ReadLine());

            Arreys arr = new Arreys(size);
            arr.Show();

            Console.WriteLine("\nВпорядкований масив:");
            arr.RandShow();

            Console.WriteLine("\n\nВведіть число, щоб взнати кількість елементів менших за нього: ");
            int L = Convert.ToInt32(Console.ReadLine());
            int SumLess = arr.Less(L);
            Console.WriteLine($"Кількість елементів менших за число {L} дорівнює {SumLess}\n");
            //arr.Show();

            Console.Write("Введіть число, щоб взнати кількість елементів більших за нього: ");
            int G = Convert.ToInt32(Console.ReadLine());
            int SumGreater = arr.Greater(G);
            Console.WriteLine($"Кількість елементів більших за число {G} дорівнює {SumGreater}\n");
            //arr.Show();
            Console.ReadLine();
        }
    }
}
