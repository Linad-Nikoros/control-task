




    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array1=new string[size];
    string[] array2=new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array1[i] = Console.ReadLine();
    }
    
SelectLengThree(array1,array2);
PrintArray(array2);

void SelectLengThree(string[] array0, string[] array1)
{
    
    for (int i = 0; i < array1.Length; i++)
    {
        if (array0[i].Length <= 3)
        {
            array1[i] = array0[i];
        }

    }
 
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (!string.IsNullOrEmpty(array[i]))
        {
            Console.WriteLine($"{array[i]}");
        }
    }
}

