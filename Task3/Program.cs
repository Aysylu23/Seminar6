/*Напишите программу, которая будет преобразовывать 
десятичное число в двоичное.

45 -> 101101
3 -> 11
2 -> 10*/

Random randomizer = new Random();
// int number = randomizer.Next(minRandomNumber, maxRandomNumber +1);
int minRandomNumber = 5;
int maxRandomNumber = 10;
string result = string.Empty;
int number = randomizer.Next(minRandomNumber, maxRandomNumber +1);
int[] numbers = new int[6];

Console.WriteLine(number);
 
while (number >= 1)
{

  result = number % 2 + result;
   number = number / 2;
}
Console.WriteLine(result);






int number = ReadInt("Введите номерчисло: ");
string output = string.Empty;
int tempNumber = number;
int baseNumber = 2;

while(tempNumber > 0)
{
    output = tempNumber % baseNumber + output;
    tempNumber /= baseNumber;
}
Console.WriteLine(output);

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int number = ReadInt("Введите число: ");
int baseNumber = 2;
int tempNumber = number;
int size = 0;

while(tempNumber > 0)
{
    tempNumber /= baseNumber;
    size++;
}
int[] result = new int[size];

tempNumber = number;

int i = 0;
while(tempNumber > 0)
{
    result[i] = tempNumber % baseNumber;
    tempNumber /= baseNumber;
    i++;
}

for(i = 0; i < result.Length / 2; i++)
{
    int temp = result[i];
    result[i] = result[result.Length - 1 - i];
    result[result.Length - 1 - i] = temp;
}

PrintIntArray(result);

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintIntArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}