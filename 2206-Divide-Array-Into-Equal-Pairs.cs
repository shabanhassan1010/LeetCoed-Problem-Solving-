public class Solution {
    public bool DivideArray(int[] nums) 
    {
        int pairs = nums.Length / 2 ;
        Array.Sort(nums);
        int count = 0;
        for(int i = 0 ; i < nums.Length ; i+=2)
        {
            if (nums[i] == nums[i+1])
            count ++;
            else
            break;
        }
        if (count == pairs) return true ;
        return false;

    }
}