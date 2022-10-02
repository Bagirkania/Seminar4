void Zadacha1()
{
int a = 3;
int b = 5;
int result = 1;

for(int i = 1; i <= b; i++)
{
   result *= a;
}
Console.WriteLine($"число {a} в степени {b} равно {result}");
}

Zadacha1();