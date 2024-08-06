public class Solution 
{
    public void MoveZeroes(int[] nums) 
    {
        int value = 0;
        for(int i = 0 ; i < nums.Length ; i++)
        {
            if(nums[i] != 0)
            {
              nums[value] = nums[i];
             value++;
            }         
        }
        for(int i = value ; i < nums.Length ; i++)
        {
            nums[i]= 0;
        }       
    }
}