public class Solution 
{
    public int ArraySign(int[] nums) 
    {
        int Count = 0;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(nums[i] == 0)
            return 0;
            else if(nums[i] < 0 )
            Count ++;
        }
        if(Count % 2 == 0)
        return 1;
        else 
        return -1;
        // return count % 2 == 0 ? 1 : -1;
    }
}