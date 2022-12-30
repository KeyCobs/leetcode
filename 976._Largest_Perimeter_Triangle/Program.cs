int[] case1 = { 2, 2, 1 };
int[] case2 = { 1, 2, 1,10 };
int[] case3 = { 3, 6, 2, 3 };

Console.WriteLine(LargestPerimeter(case1) + " Correct answer is: 5");
Console.WriteLine(LargestPerimeter(case2) + " Correct answer is: 0");
Console.WriteLine(LargestPerimeter(case3) + " Correct answer is: 8");


int LargestPerimeter(int[] nums)
{
    //1: Check if it's a triangle
    if (nums.Length < 3)
    {
        return 0;
    }
    //Put it in Descending order. Takes the biggest permiter first
    Array.Sort(nums);
    Array.Reverse(nums);

    for (int i = 0; i < nums.Length - 2; i++)
    {

        if (nums[i] < (nums[i + 1] + nums[i + 2]))
        {
            return nums[i] + nums[i + 1] + nums[i + 2];
        }
    }
    //If nothing makes a triangle then just return 0
    return 0;
}

