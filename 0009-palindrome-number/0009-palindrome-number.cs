public class Solution 
{
    // Method to check if an integer is a palindrome
    public bool IsPalindrome(int x)
    {
        // Convert the integer to a string
        string mystr = Convert.ToString(x);
        
        // Get the length of the string
        int n = mystr.Length;
        
        // Initialize two pointers: one at the start of the string and one at the end
        int i = 0;
        int j = n - 1;
        
        // Loop until the pointers meet or cross each other
        while (i <= j)
        {
            // If the characters at the current positions are not equal, return false
            if (mystr[i] != mystr[j])
            {
                return false;
            }
            // Move the pointers towards the middle of the string
            i++;
            j--;
        }
        
        // If the loop completes without returning false, the string is a palindrome
        return true;
    }
}
