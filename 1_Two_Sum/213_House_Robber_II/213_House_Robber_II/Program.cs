int[] nums = new int[]{1,2,3,1};
List<int> idx = new List<int>();

while (true)
{
    int n = nums[0];
    int id = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        if (n < nums[i] && !idx.Contains(i) && IsCheckAdj(i, idx))
        {
            n = nums[i];
            id = i; 
        }
    }
    idx.Add(id);

}

static bool IsCheckAdj(int id, List<int> idx)
{
    for (int i = 0; i < idx.Count; i++)
    {
        if ((idx[i] + 1) < i || (idx[i] -1) > i)
        {
            return false;

        }
    }

    return true;
}


static int CheckIndex(int[] n)
{

    return 0;
}

static bool CheckNumAvail()
{
    return true;
}


