// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] Array()
{
    System.Console.Write("Введите количество элементов массива: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    int [] arr = new int [numb];
    for (int i = 0; i<arr.Length; i++)
    {
        System.Console.Write($"Введите {i+1}й элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void ShowArray (int[] arr)
{
    for (int i = 0; i<arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

ShowArray(Array());