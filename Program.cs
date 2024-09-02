using static System.Console;

int a = 8;
if(a < 0)
{
    WriteLine($"O número {a} é negativo.");
}
else if(a > 0 && a < 10)
{
    WriteLine($"O número {a} esta entre 0 - 10.");
}
else
{
    WriteLine($"O número {a} é maior que 10.");
}
