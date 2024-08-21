public class Solution {
    public bool IsArraySpecial(int[] nums) 
    {
        bool answer = true;
        for(int i = 0; i < nums.Length - 1; i++) // Use nums.Length
        {
            if(nums[i] % 2 == nums[i + 1] % 2) 
            {
                answer = false;
                break; // The break should be inside the if block
            }
        }
        return answer;
    }
}
