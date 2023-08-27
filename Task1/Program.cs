// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵); 2, 4 -> 16

int GetNumber(){
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int RaisingNumber(int A, int B){
    int raising = A;
    for (int i=2; i <= B; i++)
    {
       raising = raising * A ;
       Console.WriteLine(i + "|" + raising);
    } 
    return raising;
}

int A = GetNumber();
int B = GetNumber();
int fin = RaisingNumber(A, B);
Console.WriteLine(A + " в степени " + B + " равно " + fin);