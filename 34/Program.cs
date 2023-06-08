// Задача 1: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArr(int len){

    int[] arr = new int[len];

    for (int i = 0; i < len; i++){
        arr[i] = new Random().Next(100, 1000);
    }

    return arr;
}


int GetQuantity(int[] array){

    int result = 0;

    foreach (int el in array){

        result += el % 2 == 0 ? 1 : 0; 
        //if (el % 2 == 0) result += 1;
    
    }

    return result;
}


Console.WriteLine("Введите размер массива");
int len = int.Parse(Console.ReadLine());
int[] result = GetArr(len);
int quant = GetQuantity(result);

Console.WriteLine($"Ваш массив [{String.Join(", ", result)}]");
Console.WriteLine($"Сумма четных равна {quant}");