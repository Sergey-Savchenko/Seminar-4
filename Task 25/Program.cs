// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)

// 452 -> 11
// 82 -> 10
// 9012 -> 12

void Test(int a){
    int i=0;
    int b=a;
    while(b>0) {
        i++;
        b/=10;
    }
    System.Console.WriteLine($"Количество цифр в числе: {i}");
    int c=0;
    int sum=0;
    while(c<=i) {
        int step = Convert.ToInt32(Math.Pow(10, c));
        int dec = a / step % 10;
        sum = sum + dec;
        c++;
    }
    System.Console.WriteLine($"Сумма цифр в числе: {sum}");
}

System.Console.Write("Введите число: ");
int numb = Convert.ToInt32(Console.ReadLine());
Test(numb);