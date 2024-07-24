public class Solution
{
    public int PivotIndex(int[] nums) 
    {
        int totalSum = 0;
        int leftSum = 0;

        // Calculate the total sum of the array
        foreach (int num in nums)
        {
            totalSum += num;
        }
        // Iterate through the array to find the pivot index
        for (int i = 0; i < nums.Length; i++)
        {
            // Check if the current index is the pivot index
            if (leftSum == (totalSum - leftSum - nums[i]))
            {
                return i;
            }
            // Update left sum for the next index
            leftSum += nums[i];
        }
        // Return -1 if pivot index is not found
        return -1;
    }  
}