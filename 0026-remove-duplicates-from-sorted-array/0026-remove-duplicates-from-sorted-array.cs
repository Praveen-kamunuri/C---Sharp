public class Solution
{
    // Method to remove duplicates from a sorted array of integers
    public int RemoveDuplicates(int[] nums)
    {
        // Initialize a pointer `i` to keep track of the position of the current non-duplicate element
        int i = 0;
        
        // Get the length of the input array
        int n = nums.Length;
        
        // Loop through the array starting from the second element
        for(int j = 1; j < n; j++)
        {
            // If the current element is not equal to the previous non-duplicate element
            if (nums[j] != nums[i])
            {
                // Move the current non-duplicate element pointer one step forward
                // and update the value of the next non-duplicate element
                nums[i+1] = nums[j];
                
                // Increment the pointer `i` to point to the next non-duplicate element
                i++;
            }
        }
        
        // The length of the modified array (non-duplicate elements) is `i + 1`
        // because the index `i` represents the last non-duplicate element index
        // and we add 1 to include the first element (which is always non-duplicate)
        return i + 1;
    }
}
