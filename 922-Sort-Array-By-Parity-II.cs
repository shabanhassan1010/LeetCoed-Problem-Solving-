public class Solution {
    public int[] SortArrayByParityII(int[] nums) 
    {
        int n = nums.Length ;
        int [] result = new int [n];
        int oddNumbers = 1;
        int evenNumbers = 0;
        for(int i = 0 ; i < n ; i++)
        {
            if (nums[i] % 2 == 0) // number is even
            {
            result[evenNumbers] = nums[i];
            evenNumbers += 2;
            }        
            else
            {
            result[oddNumbers] = nums[i];
            oddNumbers += 2;
            }
        }
        return result;
    }
}