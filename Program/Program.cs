using static System.Console;

Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(ReadLine()!);

string[] array1 = new string[elementsCount];
for (int i = 0; i < array1.Length; i++)
{
    Write($"Введите {i + 1} элемент массива: ");
    array1[i] = ReadLine()!;
}
ForegroundColor = ConsoleColor.Blue;
WriteLine($"[{String.Join(", ", array1)}]");
int size = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length < 4)
        size++;
}
string[] array2 = new string[size];
int j = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length < 4)
    {
        array2[j] = array1[i];
        j++;
    }
}
WriteLine("------------------------------");
ForegroundColor = ConsoleColor.Green;
WriteLine($"[{String.Join(", ", array2)}]");
ResetColor();
