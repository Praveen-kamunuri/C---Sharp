public class Solution
{
    public int Reverse(int x)
    {
        long ans = 0;
        
        while( x != 0)
        {
            int rem = x % 10;
            ans = ans * 10 + rem;
            x = x / 10;
        }
        
        if (ans < int.MinValue || ans > int.MaxValue) 
        {
            return 0;
        }
        return (int)ans;
    }
}