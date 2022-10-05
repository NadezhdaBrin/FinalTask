// Программа, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

void createArr(string[] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элеммент массива: ");
        arr[i] = Console.ReadLine();
    }
}

void createNewArr(string[] arr) 
{
    string[] newarr = new string[arr.Length]; 
    int count = 0;                                        
    for (int i = 0; i < arr.Length; i++)      
    {
        if (arr[i].Length <= 3)
        {
            newarr[count] = arr[i];
            count++;
        }
    }
    Console.WriteLine("Новый массив");        
    Console.WriteLine(string.Join(" ", newarr));
}

void PrintArray(string[] arr)       
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.Write("]");
}

Console.Write("Задайте количество строк: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];
createArr(array);
PrintArray(array);
Console.WriteLine();
createNewArr(array);
