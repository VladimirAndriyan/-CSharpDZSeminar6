// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Сколько чисел будет введено?");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
int[] array = new int[M];
for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    array[i] = number;
    if(number > 0) count +=1;
}

Console.Write(string.Join(", ", array));
Console.WriteLine($" -> {count}");