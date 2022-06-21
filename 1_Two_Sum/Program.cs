int[] num = new int[] {2,7,11,15 };
int target = 9;
int[] answ = new int[2];

for (int i = 0; i < num.Length; i++)
{
    for(int j = i+1; j < num.Length-i; j++)
    {
        if (num[i] + num[j] == target)
        {
            answ[0] = i;
            answ[1] = j;
            break;
            //return answ;
        }
    }
    
}

foreach (int e in answ)
{
    Console.Write(e + " | ");
}
