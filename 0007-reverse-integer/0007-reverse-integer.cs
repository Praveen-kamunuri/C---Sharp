public class Solution
{
    // Method to reverse an integer
    public int Reverse(int x)
    {
        // Variable to store the reversed integer
        long ans = 0;
        
        // Loop to reverse the integer digit by digit
        while (x != 0)
        {
            // Extracting the last digit of the integer
            int rem = x % 10;
            
            // Building the reversed integer by adding the last digit
            // to the current result multiplied by 10
            ans = ans * 10 + rem;
            
            // Removing the last digit from the integer
            x = x / 10;
        }
        
        // Checking for overflow
        if (ans < int.MinValue || ans > int.MaxValue)
        {
            return 0; // Return 0 if overflow occurs
        }
        
        // Casting the result to int and returning
        return (int)ans;
    }
}
