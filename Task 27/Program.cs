// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void Test(int a, int b){
    int step = a;
    for (int index=1 ; index<b ; index++) {
        step = step*a;
    }
    System.Console.Write($"Натуральная степень {b} числа {a} равна {step} ");
}

System.Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите степень: ");
int stepen = Convert.ToInt32(Console.ReadLine());
Test(numb, stepen);