public class Solution 
{
    // Use SortedSet Topic 
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        // Input : nums1 = [1,2,3],   nums2 = [2,4,6]
        // Output: [[1,3],[4,6]]
        // Convert arrays to HashSets to easily find differences
        SortedSet<int> set1 = new SortedSet<int>(nums1);
        SortedSet<int> set2 = new SortedSet<int>(nums2);

        // Find differences and Retuen the value in list Not array or any Collection Type
        var onlyInNums1 = set1.Except(set2).ToList();
        var onlyInNums2 = set2.Except(set1).ToList();

        // Return results as a list of lists
        return new List<IList<int>> { onlyInNums1, onlyInNums2 };
    }
}