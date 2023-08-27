// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10; 9012 -> 12

int GetNumber(){
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNumbers(int number){
    int sumnumbers = 0;
    while ( number >= 1)
    {
    sumnumbers = sumnumbers + number % 10;
    number = number / 10;
    }
    return sumnumbers;
}

int number = GetNumber();
int fin = SumNumbers(number);
Console.WriteLine("Сумма цифр в числе " + number + " равна " + fin);