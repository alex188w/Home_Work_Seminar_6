void Zadacha_41() 
// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь
{
    Random random = new Random();
    int size = random.Next(5, 10);
    int[] array = new int[size];
    FillArray(array, -10, 10);
    Console.WriteLine("Пользователь ввел следующие числа: ");
    PrintArray(array);
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    Console.WriteLine($"Пользователь ввел {count} числа (чисел) больше 0");
}

void Zadacha_43()
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2
// задаются пользователем

// Решение мат.: в точке пересечения прямых у1 = у2, х1 = х2. Приравниваем уравнения, находим х,
// из уравнения прямой 1 находим у. Возможны случаи, когда (k1 = k2) - нет точек пересечения и 
// (b2 = b1) & (k1 = k2) - прямые совпадают (здесь не рассматривается.)
{
    Console.WriteLine("Введите коэффициент b1 ");
    double b1 = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите значение k1 ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите коэффициент b2 ");
    double b2 = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите значение k2 ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    if (k1 == k2) Console.WriteLine("Прямые не имеют точек пересечения - параллельны");
    else
    {
    double x = (b2 - b1)/(k1 - k2);    
    double y = k1 * x + b1;   
    Console.WriteLine($"Координаты точки пересечения прямых ({x}; {y})");
    }    
}

void FillArray(int[] array, int startNumber, int finishNumber)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

//Zadacha_41();
Zadacha_43();