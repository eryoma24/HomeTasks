Console.WriteLine("Введите число (N) => ");
string inputedString = Console.ReadLine();
int N = Convert.ToInt32(inputedString);

Console.WriteLine($"Каждое чётное число от 1 до {N} => ");

int Z = 2;
while (Z <= N)
{
    Console.WriteLine(Z);
    Z += 2;
}