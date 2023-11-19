/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write("Введите числа через запятую: ");
string inputNumbers = Console.ReadLine();



int size = 1;
for(int i = 0; i < inputNumbers.Length; i++)
{
    if(inputNumbers[i] == ',')
        size++;
}

int[] numbers = new int[size];

string subString = string.Empty;
int numbersIndex = 0;
for(int i = 0; i < inputNumbers.Length; i++)
{
    if(inputNumbers[i] == ',')
    {
        numbers[numbersIndex] = Convert.ToInt32(subString);
        subString = string.Empty;
        numbersIndex++;
    }
    else
    {
        subString += inputNumbers[i];
    }
}
numbers[numbersIndex] = Convert.ToInt32(subString);

int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}

Console.WriteLine($"-> {sum}");


void PrintIntArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}