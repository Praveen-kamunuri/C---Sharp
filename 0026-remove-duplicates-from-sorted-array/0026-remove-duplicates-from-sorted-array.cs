public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int i = 0;
        int n = nums.Length;
        for(int j = 1; j < n; j++)
        {
            if (nums[j] != nums[i])
            {
                nums[i+1] = nums[j];
                i++;
            }
            
        }
        return i + 1;
    }
}