//Задача 38: Задайте массив целых чисел. 
//Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] => 76



int[] GetArr(int len){

    int[] arr = new int[len];

    for (int i = 0; i < len; i++){
        arr[i] = new Random().Next(1, 100);

    }

    return arr;
}


int GetDif(int[] array){

    int max = array[0];
    int min = array[0];
    int dif = 0;


    foreach (int el in array){

        // if (el > max) {
        //     max = el;
        // }
        // if (el < min) {
        //     min = el;
        // }
        
       max = el > max ? el : max; 
       min = el < min ? el : min; 
        
    }
   
    dif = max - min;

    return dif;

}


Console.WriteLine("Введите размер массива");
int len = int.Parse(Console.ReadLine());
int[] result = GetArr(len);
int dif = GetDif(result);

Console.WriteLine($"Ваш массив [{String.Join(", ", result)}]");
Console.WriteLine($"Разница равна {dif}");