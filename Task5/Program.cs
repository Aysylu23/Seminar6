// Напишите программу, которая будет создавать копию заданного 
// одномерного массива с помощью поэлементного копирования.
int size = ReadInt("Введите размер массива: ");
Random randomizer = new Random();
int[] numbers = new int[size];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = randomizer.Next(0, 10);
}

int[] result = CopyArray(numbers);

PrintIntArray(numbers);
PrintIntArray(result);

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for (int i = 0; i < copyArray.Length; i++)
    {
        copyArray[i] = array[i];
    }

    return copyArray;
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintIntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}
