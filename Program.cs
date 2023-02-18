using System;
using System.Collections;
using System.Drawing;

class Menu
{
        private static int[] arr = new int[7];
        private static int n = 0;

       public static void ConsoleMenu(ref int num)
       {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Создать массив");
            Console.WriteLine("2. Вывести элементы массива");
            Console.WriteLine("3. Сортировка выбором");
            Console.WriteLine("4. Примаидальная сортировка");
            Console.WriteLine("5. Сортировка пузырьком");
            Console.WriteLine("6. Шейкер сортировка");
            Console.WriteLine("7. Выход\n");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    CreateArray(ref arr); break;
                case 2: Print(ref arr); break;
                case 3: ChoiceSort(ref arr); break;
                case 4: HeapSort(ref arr); break;
                case 5: BubbleSort(ref arr); break;
                case 6: ShakerSort(ref arr); break;
                default:
                    break;
            }
       }

    private static void CreateArray(ref int[] arr)
    {
        Console.WriteLine("Введите размер массива");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Заполните массив {n} элементами через Enter");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введите элемент на {i} позицию:\t");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Заполнение окончено\n");
    }
    private static void Print(ref int[] arr)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
    
    private static void ChoiceSort(ref int[] arr)
    {
        if (n > 0)
        {
            int MinIndex;
            for (int i = 0; i < arr.Length; i++)
            {
                MinIndex = i;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] < arr[MinIndex])
                    {
                        MinIndex = j;
                    }
                }
                if (arr[MinIndex] == arr[i])
                {
                    continue;
                }

                int tmp = arr[i];
                arr[i] = arr[MinIndex];
                arr[MinIndex] = tmp;
            }
        }
        else
        {
            Console.WriteLine("Пустой массив.");
        }
    }
    private static void BubbleSort(ref int[] arr)
    {
        if (n > 0)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - j; j++)
                {
                   if (arr[j] > arr[j + 1])
                   {
                       int replace = arr[j];
                       arr[j] = arr[j + 1];
                       arr[j + 1] = replace;
                   }
                }
            }
        }
        else
        {
            Console.WriteLine("Пустой массив.");
        }
    }
    static void Swap(ref int[] arr, int i, int j)
    {
        int tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
    }
    static void ShakerSort(ref int[] arr)
    {
        if (n > 0)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(ref arr, i, i + 1);
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (arr[i - 1] > arr[i]) Swap(ref arr, i - 1, i);
                }
                left++;
            }
        }
        else
        {
            Console.WriteLine("Пустой массив.");
        }
    }
    static void HeapSort(ref int[] arr)
    {
    Console.WriteLine("Я пытался, но у меня не получилось.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        do
        {
            Menu.ConsoleMenu(ref number);
        } while (number != 7);
    }
}
