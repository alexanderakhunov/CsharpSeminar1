Console.Write("Введите ваше число 1: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ваше число 2: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if  (FirstNumber / SecondNumber == SecondNumber)
    {
        Console.Write("Является квадратом");
    }
    else
    {
     Console.Write("Не является квадратом");
    };
