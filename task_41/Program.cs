// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Zadaha_41()
{
    Console.Write("Сколько чисел будем вводить в массив?: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[m];

    FillArray(array);
}

void FillArray(int[] array)
{
    int col = 0;
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите чисело {i+1}: ");
        int m_number = Convert.ToInt32(Console.ReadLine());

        array[i] = m_number;

        if(m_number > 0)
        {
            col++;
        }

        Console.WriteLine($"Чисел больше ноля в массиве: " + col);
        Console.WriteLine();
    }
    PrintArray(array);
}

void PrintArray(int[] array)
{
    string arr = string.Join(", ", array);
    Console.WriteLine($"В массив введены числа: " + arr);
    Console.WriteLine();
}

Zadaha_41();