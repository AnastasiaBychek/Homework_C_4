Console.WriteLine("Input number A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B");
int B = Convert.ToInt32(Console.ReadLine());

int Method (int x, int y)
{
    int result = 0;
    if(x>0 && y>0) 
    {
    result = Convert.ToInt32(Math.Pow(A,B));
    }
    return result;  
}
Method(A,B);
Console.WriteLine(Method(A,B));