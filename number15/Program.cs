Console.WriteLine("Введите цифру от 1 до 7: ");
int num = int.Parse(Console.ReadLine());

if (num <= 5)
{
    Console.WriteLine("Будний день");
}
else if (num==6 || num==7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Вы ввели не правильное число, введите от 1 до 7");
}