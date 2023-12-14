// See https://aka.ms/new-console-template for more information
Console.WriteLine("Scored 100%");

static int Solution(int[] P, int[] S)
{
    int total_pass = P.Sum();
    int res = 0;
    Array.Sort(S);
    Array.Reverse(S);
    foreach (int i in S)
    {
        if (total_pass - i > 0)
        {
            total_pass -= i;
            res += 1;
        }
        else
        {
            res += 1;
            return res;
        }
    }
    return res;
}
