public class Solution {
    public bool IsPossibleToSplit(int[] nums) 
    {
         if (nums.Length % 2 != 0)
            return false; // The length should be even

        int half = nums.Length / 2;
        var frequency = new Dictionary<int, int>();

        // Count frequency of each element
        foreach (var num in nums) 
        {
            if (frequency.ContainsKey(num))
                frequency[num]++;
            else
                frequency[num] = 1;
        }

        // Check if it's possible to split
        foreach (var kvp in frequency) 
        {
            // If any element appears more than twice, it's not possible to split
            if (kvp.Value > 2)
                return false;
        }

        return true;
    
    }
}
