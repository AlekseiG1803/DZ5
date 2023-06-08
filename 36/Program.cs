// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArr(int len){

    int[] arr = new int[len];

    for (int i = 0; i < len; i++){
        arr[i] = new Random().Next(-100, 101);
    }

    return arr;
}


int GetSumOdd(int[] array){

    int result = 0;

    for (int i = 0; i < array.Length; i++){
        result = i % 2 == 0 ? result : (result + array[i]);
    }

    return result;
}


Console.WriteLine("Введите размер массива");
int len = int.Parse(Console.ReadLine());
int[] result = GetArr(len);
int sum = GetSumOdd(result);

Console.WriteLine($"Ваш массив [{String.Join(", ", result)}]");
Console.WriteLine($"Сумма нечетных равна {sum}");