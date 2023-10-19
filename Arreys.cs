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
    internal class Arreys : ICalc
    {
        int[] ar;
        public Arreys(int size)
        {
            Console.Write("Введіть нижню межу рандомних значень масиву: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть нижню межу рандомних значень масиву: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            ar = new int[size];
            for (int i = 0; i < size; i++)
            {
                ar[i] = r.Next(a, b);
            }
        }
        public void Input(int size)
        {
            ar = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введіть значення елементу {i + 1}: ");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
        public void Show()
        {
            Console.Write("Елементи масиву:\n");
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write($"{ar[i]} ");
            }
            Console.WriteLine();
        }
        public void RandShow()
        {
            Array.Sort(ar);
            foreach (int i in ar)
            {
                Console.Write($"{i} ");
            }
        }
        public int Less(int valueToCompare)
        {
            int n = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (valueToCompare > ar[i])
                {
                    n++;
                    Console.WriteLine($"Елемент {ar[i]};");
                }
            }
            return n;
        }
        public int Greater(int valueToCompare)
        {
            int n = 0;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                if (valueToCompare < ar[i])
                {
                    n++;
                    Console.WriteLine($"Елемент {ar[i]};");
                }
            }
            return n;
        }
    }
}
