public class Solution {
    public bool IsArraySpecial(int[] nums) 
    {
        bool answer = true;
        for(int i = 0; i < nums.Length - 1; i++) // Iterate from the first element to the second-to-last element
        {
            if(nums[i] % 2 == nums[i + 1] % 2)  // Check if current and next elements have the same parity
            {
                answer = false;
                break; // The break should be inside the if block
            }
        }
        return answer;
    }
}
