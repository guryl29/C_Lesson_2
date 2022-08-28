Console.WriteLine("Введите целое число ");
int num = int.Parse(Console.ReadLine());

if (num <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if(num >=1000) num/=100;
    int result = num % 10;
    {
        Console.WriteLine($" Третья цифра введеного числа {result} ");
    }
}