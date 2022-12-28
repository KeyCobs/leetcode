uint case1 = 11;
uint case2 = 1;
//uint case3 = 11111111111111111111111111111101;

Console.WriteLine("Test case1: " + HammingWeight(case1) + " Should be: 3");
HammingWeight(case2);
Console.WriteLine("Test case2: " + HammingWeight(case1) + " Should be: 1");
//HammingWeight(case3);

int HammingWeight(uint n)
{
    return System.Numerics.BitOperations.PopCount(n);
}