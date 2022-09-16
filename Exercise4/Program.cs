bool isEven(int num) 
{
    if (num % 2 == 0)
    {
        return true;
    }
    else 
    {
        return false;
    }
};

Console.WriteLine("Введите число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
if (number <= 0) {
    Console.WriteLine("Число не соответствует условию!");
}
else {
    while(result < number)
    {
        result++;
        if(isEven(result)) 
        {
        Console.WriteLine(result);
        }
    }
};
