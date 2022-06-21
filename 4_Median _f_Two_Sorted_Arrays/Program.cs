//public class Solution
//{
//    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
//    {
int[] nums1 = new int[] { 1, 2 };
int[] nums2 = new int[] { 3,4};
        int[] merge = new int[nums1.Length + nums2.Length];

        for (int i = 0; i < nums1.Length; i++)
        {
            merge[i] = nums1[i];
        }

        for (int j = 0; (j + nums1.Length) < merge.Length; j++)
        {
            merge[j + nums1.Length] = nums2[j];
        }

        Array.Sort(merge);

        if (merge.Length % 2 == 0)
        {
            Console.Write((merge[merge.Length / 2] + merge[merge.Length / 2 - 1]) / 2.0);
            //return merge[merge.Length / 2] + merge[merge.Length / 2 + 1]) / 2;
        }
        else
        {
            Console.Write(Convert.ToDouble(merge[(merge.Length / 2)]));
            //return Convert.ToDouble(merge[(merge.Length / 2) + 1]);
        }

//    }
//}