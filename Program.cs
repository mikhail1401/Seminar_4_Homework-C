Console.WriteLine("Task 25");
// Напишите цикл, который принимает на вход два числа (А и В) и возводит
// число А в натуральную степень В.
// 3, 5 -> 243 (3^5)       2, 4 -> 16

Console.Write("Enter a number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number b: ");
int b = Convert.ToInt32(Console.ReadLine());

int RaisingToPower()
{
    int count=1;
    int result=1;

    while(count<=b)
    {
        result=result*a;
        count++;
    }
    return result;
}

Console.WriteLine(RaisingToPower());


Console.WriteLine("\nTask 27");
// Напишите программу, котора принимает на вход число и выдает сумму цифр в числе.
// 452 -> 11       82 -> 10        9012 -> 12

int SumOfNum(int num)
{
    int sum=0;

    while(num>0)
    {
        sum=sum+num%10;
        num=num/10;
    }

    return sum;
}

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfNum(num));


Console.WriteLine("\nTask 29");
// Напишите программу, котора задает массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 8, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];

void GetArray()
{
    for(int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
        Console.Write(array[i] + " ");
    }
}

GetArray();
