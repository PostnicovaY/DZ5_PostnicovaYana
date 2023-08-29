// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Можно было сделать все в 1 методе, но по формулировке ДЗ
// программа должна выполнить определенное действие
// (показать количество чётных чисел в массиве), а сам массив могут
// как дать готовый, так и заполнить рандомно, поэтому разделила
int[] array = new int[10];

int[] FillArray(int[] array){
        for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(100,1000);
    }
    Console.WriteLine(String.Join(" ", array));
    return array;   
}

int[] newArray = FillArray(array);
evenNumberCounter(newArray);

void evenNumberCounter(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 == 0){
            count++;
        }
    }
    Console.WriteLine("Количество чётных чисел в массиве - " + count);
}

