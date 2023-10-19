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
    internal interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }
}
