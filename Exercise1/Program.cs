Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2) 
{
    Console.WriteLine($"{num1} больше чем {num2}!");
}
else if (num1 < num2)
{
    Console.WriteLine($"{num2} больше чем {num1}!");
}
else
{
    Console.WriteLine($"{num1} и {num2} равны!");
}