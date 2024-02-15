public class Solution
{
    public bool Check(int[] nums)
    {
        int count = 0;  // Counter for the number of times the array is rotated
        
        int n = nums.Length;  // Get the length of the array
        
        // Iterate through the array to check if it's rotated
        for(int i = 1; i < n; i++)
        {
            if (nums[i-1] > nums[i])  // If current element is smaller than previous, it indicates rotation
            {
                count++;  // Increment the counter
                
            }
            
        }
        
        // Check the transition between the last and first elements
        if (nums[n-1] > nums[0])  // If last element is greater than first, it indicates rotation
        {
            count++;  // Increment the counter
        }
        
        // If the counter is less than or equal to 1, it means the array is sorted and rotated
        return count <= 1;
    }
}
