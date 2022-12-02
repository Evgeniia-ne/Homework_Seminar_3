Console.Clear();
double DataЕntry(string str)
{
    Console.Write(str);
    double number = double.Parse(Console.ReadLine());
    return number;
}
double number = DataЕntry("Введите число: ");
double count = 1;
while (count <= number)
{
    Console.WriteLine(Math.Pow(count, 3));// Math.Pow((y2 - y1), 2));
    count++;
}
