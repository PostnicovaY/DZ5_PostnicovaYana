// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] 
// => 77.15 - 1.15 = 76
using System; // эти 2 команды нужны для других примеров 
// (Ну вот захотела я посмотреть, как еще можно работать с массивами ¯\_(ツ)_/¯)
using System.Linq;

double[] array = new double[10];

double[] FillArray(double[] array){
        for (int i = 0; i < array.Length; i++){
        array[i] = Math.Round(new Random().NextDouble() * 5, 3);
    }
    Console.WriteLine(String.Join(" | ", array));
    return array;   
}

double[] newArray = FillArray(array);
difference(newArray);
difference2(newArray); // Вариант 2
difference3(newArray); // Вариант 3

// Вариант 1:
void difference(double[] array){
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++){
        if (array[i] > max){
            max = array[i];
        } else if (array[i] < min){
            min = array[i];
        }
    }
    Console.WriteLine("Максимальное - " + max + ", минимальное - " + min);
    Console.WriteLine("Разница между максимальным и минимальным элементов массива - " + (max - min));
}

// Вариант 2:

void difference2(double[] array){
    Console.WriteLine("Максимальное - " + array.Max() + ", минимальное - " + array.Min());
    Console.WriteLine("Разница между максимальным и минимальным элементов массива - " + (array.Max() - array.Min()));
}

// Вариант 3:

void difference3(double[] array){
    Array.Sort(array);
    if (array.Length > 0){
        Console.WriteLine("Максимальное - " + array[array.Length - 1] + ", минимальное - " + array[0]);
        Console.WriteLine("Разница между максимальным и минимальным элементов массива - " + (array[array.Length - 1] - array[0]));
    }
    
}
