public class Solution
 {
    public int[] GetConcatenation(int[] nums) 
    {
        
        int n = nums.Length;   // lw El-Length = 5
        int[] res = new int[n * 2]; // hna ana 3amlt array  El-Length = 10
        for (int i = 0; i < n; i++)
        {
            res[i] = nums[i]; // set all index from nums array in res[i], now res[i] feha array nums
        }
        for (int i = 0; i < n; i++)
        {
            res[ n + i ] = nums[i]; // hna ana add copy of El-Array 
        }
        return res;
    }
}