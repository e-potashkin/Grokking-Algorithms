namespace Chapter_3;

public class Recursion
{
    public int? Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
    }
}
