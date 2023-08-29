// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите 
// сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];

int[] FillArray(int[] array){
        for (int i = 0; i < array.Length; i++){
        array[i] = new Random().Next(-9,9);
    }
    Console.WriteLine(String.Join(" ", array));
    return array;   
}

int[] newArray = FillArray(array);
numbersSum(newArray);

void numbersSum(int[] array){
    int count = 0;
    for (int i = 1; i < array.Length; i += 2){
        count += array[i];
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных индексах - " + count);
}