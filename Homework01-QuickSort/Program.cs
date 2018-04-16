/* Дан массив размера N. Отсортируйте его по возрастанию методом "Быстрой сортировки".
 Отличительной особенностью быстрой сортировки является операция разбиения массивы на две 
 части относительно опорного элемента. Например, если последовательность требуется упорядочить 
 по возрастанию, то в левую  часть будут помещены все элементы, значения которых меньше значения
 опорного элемента, а в правую - элементы, чьи значения больше опорного или равны опорному.
 Вне зависимости от того, какой элемент выбран в качестве опорного, массив будет отсортирован,
 но все же наиболее удачной считается ситуация, когда по обеим сторонам от опорного элемента
 оказывается примерно равное количество элементов. Если длина какой-то из получившихся в результате
 разбиения частей превышает один элемент, то для нее нужно рекурсивно выполнить упорядочивание, т.е
 повторно запустить алгоритм на каждом из отрезков. Таким образом, алгоритм быстрой сортировки
 включает в  себя два основных этапа: разбиение массива относительно опорного
 элемента; рекурсивная сортировка каждой части массива*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrForSort = { 5, 4, 9, 1, 6, 2, 3, 7 };
                Console.WriteLine("Исходный массив:");
                foreach (int item in arrForSort)
                {
                    Console.WriteLine(item);
                }
            

            int[] newArr = QuickSort(arrForSort, 0, arrForSort.Length - 1);
                Console.WriteLine("Отсортированный массив:");
                foreach (int item in newArr)
                {
                    Console.WriteLine(item);
                }
        }

        static int[] QuickSort (int[] arrSort, int firstNum, int lastNum)
        {
            int numFirstElem = firstNum;
            int numLastElem = lastNum;
            int numMainElem = (numLastElem + numFirstElem) / 2;
            int mainElem = arrSort[numMainElem];

            while (numLastElem > numFirstElem)
            {
                while (arrSort[numFirstElem] < mainElem)
                {
                    numFirstElem++;
                }
                while (arrSort[numLastElem] > mainElem)
                {
                    numLastElem--;
                }
                if (numFirstElem <= numLastElem)
                {
                    int tmp = arrSort[numFirstElem];
                    arrSort[numFirstElem] = arrSort[numLastElem];
                    arrSort[numLastElem] = tmp;
                    numFirstElem++;
                    numLastElem--;
                }
            }

            if (numLastElem > firstNum)
            {
                QuickSort(arrSort, firstNum, numLastElem);
            }

            if (numFirstElem < lastNum)
            {
                QuickSort(arrSort, numFirstElem, lastNum);
            }

            return arrSort;
        }
    
    }
}
