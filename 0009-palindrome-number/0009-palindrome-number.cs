public class Solution 
{
    public bool IsPalindrome(int x)
    {
        string mystr = Convert.ToString(x);
        int n = mystr.Length;
        int i = 0;
        int j = n - 1;
        
        while(i <= j)
        {
            if (mystr[i] != mystr[j])
            {
                return false;
            }
            i++ ;
            j-- ;
        }
        return true;
        
    }
}