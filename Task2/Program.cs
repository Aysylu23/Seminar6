/*40. Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.*/


int fistSide = ReadInt("Введите первое число: ");
int secondSide = ReadInt("Введите первое число: ");
int thirdSide = ReadInt("Введите первое число: ");

if (fistSide + secondSide > thirdSide && fistSide + thirdSide > secondSide && secondSide + thirdSide > fistSide)
{
    Console.WriteLine("Три числа являются сторонами треугольника");
}
else
{
    Console.WriteLine("Три числа НЕ являются сторонами треугольника");
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}