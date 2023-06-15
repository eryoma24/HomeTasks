Console.WriteLine("Введите число номер 1 => ");
string inputedString1 = Console.ReadLine();
int number1 = Convert.ToInt32(inputedString1);

Console.WriteLine("Введите число номер 2 => ");
string inputedString2 = Console.ReadLine();
int number2 = Convert.ToInt32(inputedString2);

Console.WriteLine("Введите число номер 3 => ");
string inputedString3 = Console.ReadLine();
int number3 = Convert.ToInt32(inputedString3);

int max = number1;

if (number2 > max)
{
    max = number2;
}

if (number3 > max)
{
    max = number3;
}

Console.WriteLine($"Максимальное число равно {max}! ");