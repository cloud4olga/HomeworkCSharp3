// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33]

int[]array = new int[8];
void FillArray(int[]array){
int length = array.Length;
for (int i = 0; i < 8; i++)
{
array[i] = new Random().Next(1,99);
}
String arrayOutput = String.Join("," , array);
Console.WriteLine("["+ arrayOutput + "]");
}

FillArray(array);