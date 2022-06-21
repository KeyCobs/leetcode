//https://leetcode.com/problems/furthest-building-you-can-reach/
int[] heights = new int[] { 4, 12, 2, 7, 3, 18, 20, 3, 19 };
int bricks = 10;
int ladders = 2;

//Step 1: Read the entire array and save the positions with biggest height differences for ladders
int[,] pos = new int[ladders,1];
pos[0,0] = 0;
pos[1,0] = 1;
pos[0, 1] = 0;
pos[1, 1] = 0;
for (int i = 0; i < heights.Length; i++)
{
    if (heights[i] > pos[0,0])
    {
        ShiftArray(pos);
        pos[i,0] = 0;
    }
    else if(heights[i] > pos[1, 0])
    {
        //pos[i]
    }
}
//Step 2: Rest use bricks

//if cur >= nothing
//ekse use ladder of bricks


void ShiftArray(int[,] ar)
{
    int temp = ar[0,0];
    for (int i = 1; i < ar.GetLength(0)-1; i++)
    {
        int temp2 = ar[i+1,0];
        ar[i,0] = temp;
        temp = temp2;
    }
}