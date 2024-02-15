public class Solution
{
    public bool Check(int[] nums)
    {
        int count = 0;
        
        int n = nums.Length;
        
        for(int i = 1; i < n; i++)
        {
            if (nums[i-1] > nums[i])
            {
                count++;
                
            }
            
            
        }
        
        if (nums[n-1] > nums[0])
        {
            count++;
        }
        
        return count <= 1;
    }
}