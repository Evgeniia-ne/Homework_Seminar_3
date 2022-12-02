Console.Clear();
int DataЕntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int number = DataЕntry("Введите пятизначное число: ");

if (number / 10000 == number % 10 & number / 1000 % 10 == number / 10 % 10)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");
