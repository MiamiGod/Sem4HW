// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B.
Console.WriteLine("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите натуральное число B: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число A в степени B: {Pow(a, b)}");

int Pow(int num, int rank)
{
    if (b == 0) return 1;
    int result = num;
    for (int i = 2; i <= rank; i++)
    {
        result *= num;
    }
    return result;
}

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int num=int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {num}: {SumNumbers(num)}");

int SumNumbers(int num){
    int sum=0;
    while(num>0){
        sum+=num%10;
        num=num/10;
    }
    return sum;}


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//(числа берете любые)

int[] Array = GetRandomArray(8,0,10000);
Console.WriteLine($"{String.Join(", ", Array)}");

int[] GetRandomArray(int size, int minValue, int maxValue)

{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i]=new Random().Next(minValue, maxValue);
    }
    return result;

}