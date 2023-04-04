// Задача: Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

int Prompt(string message)
{
    Console.Clear();
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

string InputArray(string message)
{
    Console.WriteLine(message);
    string result = Console.ReadLine();
    return result;
}

string[] CreateArray(int size)
{
    string[] arr = new string[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = InputArray($"Введите {i}-й элемент:");
    }
    return arr;
}

void ReducedArray(string[] arr)
{
    string str = String.Empty;
    int count = 3;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= count) arr[i] = arr[i];
        else arr[i] = str;
    }
}

void PrintArray(string[] arr)
{
    string str = String.Empty;
    Console.Write("| ");

    for (int i = 0; i < arr.Length; i++)
    {
        if (str != arr[i])
            Console.Write($"{arr[i]} ");
    }
    Console.WriteLine("|");
}

int length = Prompt("Введите длину массива: ");
string[] array = CreateArray(length);
PrintArray(array);
ReducedArray(array);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символам:");
PrintArray(array);
