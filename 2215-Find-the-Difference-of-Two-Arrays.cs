public class Solution 
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        // Input : nums1 = [1,2,3],   nums2 = [2,4,6]
        // Output: [[1,3],[4,6]]
         // Convert arrays to HashSets to easily find differences
        HashSet<int> set1 = new HashSet<int>(nums1);
        HashSet<int> set2 = new HashSet<int>(nums2);

        // Find differences and Retuen the value in list Not array or any type
        IList<int> onlyInNums1 = set1.Except(set2).ToList();
        IList<int> onlyInNums2 = set2.Except(set1).ToList();

        // Return results as a list of lists
        return new List<IList<int>> { onlyInNums1, onlyInNums2 };
    }
}