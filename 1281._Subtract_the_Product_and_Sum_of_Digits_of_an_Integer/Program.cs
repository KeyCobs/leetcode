int case1 = 234;
int case2 = 4421;

Console.WriteLine(SubtractProductAndSum(case1) + " Should be 15");
Console.WriteLine(SubtractProductAndSum(case2) + " Should be 21");



int SubtractProductAndSum(int n)
{
    string a = n.ToString();
    int t1 = 0, t2 = 1;

    foreach (char e in a)
    {
        Console.WriteLine(e);
        t1 += Convert.ToInt32(e + "");
        t2 *= Convert.ToInt32(e + ""); 
    }
    return t2 - t1;
}