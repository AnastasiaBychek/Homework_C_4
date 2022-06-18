Console.WriteLine("Input number ");
int Number = Convert.ToInt32(Console.ReadLine());

int sumnumbers(int N)
{
int sum = 0;
while (N != 0)
{
    sum = sum + N%10;
    N = N/10;
}
return sum;
}
sumnumbers(Number);
Console.WriteLine(sumnumbers(Number));