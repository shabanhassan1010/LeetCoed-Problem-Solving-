public class Solution 
{
    public void ReverseString(char[] s) 
    {
        int left = 0;
        int right = s.Length - 1; // Use Length property to get the size of the array  
        while (left < right) // Use < to avoid redundant swaps when pointers meet
        {
            // Swap characters at left and right
            char temp = s[left];
            s[left] = s[right];
            s[right] = temp;
            
            left++;
            right--;
        }
    }
}