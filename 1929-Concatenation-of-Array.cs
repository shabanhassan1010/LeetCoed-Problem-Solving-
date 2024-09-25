public class Solution
 {
    public int[] GetConcatenation(int[] nums) 
    {       
        //int n = nums.Length;   // lw El-Length = 5
        int[] arr2 = new int[nums.Length * 2]; // hna ana 3amlt array  El-Length = 10
        for (int i = 0; i < nums.Length; i++)
        {
         arr2[i] = nums[i]; // set all index from nums array in arr2[i],now arr2[i] feha array nums
        }
        for (int i = 0; i < nums.Length; i++)
        {
            arr2[ nums.Length + i ] = nums[i]; // hna ana add copy of El-Array 
        }
        return arr2;
    }
}