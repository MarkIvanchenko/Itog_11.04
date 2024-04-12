Console.WriteLine("Введите количество строк в массиве:");
int count = int.Parse(Console.ReadLine());


    string[] array = new string[count];
    
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"Введите строку {i + 1}:");
        array[i] = Console.ReadLine();
    }

    Console.WriteLine("Строки с длиной меньше 4 символов:");

    foreach (string str in array)
    {
        if (str.Length < 4)
        {
            Console.WriteLine(str);
        }
    }