// Находим 1-ю цифру заданного числа

Console.WriteLine("Задайте 5-ти значное число");
int a = Convert.ToInt32(Console.ReadLine());
int i = 10000;
if (i < a)
    while (i < 100000)
    {
        if (i > a) break;
        i = i + 1000;
    }
Console.WriteLine("Первая цифра числа " + i / 10000);


// Находим 5-ю цифру заданного числа

int b = a % 10;
int i5 = 0;
if (i5 <= b)
    while (i5 < 10)
    {
        if (i5 >= b) break;
        i5 = i5 + 1;
    }
Console.WriteLine("Пятая цифра числа " + i5);


if (i / 10000 == i5)
// Находим 2-ю цифру заданного числа
{
    int c = a / 1000 % 10;
    int i2 = 0;
    if (i2 <= c)
        while (i2 < 10)
        {
            if (i2 >= c) break;
            i2 = i2 + 1;
        }
    Console.WriteLine("Вторая цифра числа " + i2);
    // Находим 4-ю цифру заданного числа 
    int d = a / 10 % 10;
    int i4 = 0;
    if (i4 <= d)
        while (i4 < 10)
        {
            if (i4 >= c) break;
            i4 = i4 + 1;
        }
    Console.WriteLine("Четвертая цифра числа " + i4);
    if (i2 == i4)
    {
        Console.WriteLine("Палиндром");
    }

}

else
{
    Console.WriteLine("Не является Палиндромом");
}
