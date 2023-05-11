//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
Random rnd = new Random();
int[] array = new int[7];
int max=0, min=100;
    for (int i = 0; i < array.Length; i++ )  d[i] = rnd.Next(100);
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = d[i];
                if (array[i] < min) min = d[i];
            }
           
               for (int i = 0; i < array.Length; i++) Console.Write(" "+d[i]);//выводим массив
        Console.WriteLine();
        Console.WriteLine("max:  " + max);
        Console.WriteLine("min  " +min);
        Console.WriteLine("Разница максимального и минимального:  "+(max - min));