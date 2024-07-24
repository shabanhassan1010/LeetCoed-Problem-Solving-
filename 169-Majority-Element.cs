public class Solution {
    public int MajorityElement(int[] nums) 
    {
        // int value = 0;
        // int count = 0;
        // for(int i = 0 ; i < nums.Length ; i++)
        // {
        //     value = nums[i];
        //     if(nums[i] == value)
        //     count ++ ;
        // }
        // return value ;
        int candidate = 0;
        int count = 0;

        // Boyer-Moore Voting Algorithm
        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }
                return candidate;

    }
}