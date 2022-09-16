// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num1 >= num2 && num1 >= num3)
{
    max = num1;
}
if(num2 >= num1 && num2 >= num3)
{
    max = num2;
}
if(num3 >= num1 && num3 >= num2)
{
    max = num3;
}

Console.WriteLine($"Наибольшее число из трех - {max}");

