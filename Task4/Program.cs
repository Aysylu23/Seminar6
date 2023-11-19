// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
int n = ReadInt("Введите число: ");
int[] fibonacci = new int[n];
if(n > 0)
    fibonacci[0] = 0;
if(n > 1)
    fibonacci[1] = 1;

for(int i = 2; i < fibonacci.Length; i++)
{
    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}
PrintIntArray(fibonacci);


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
