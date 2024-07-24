public class Solution 
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        // Dictionaries to store counts of elements
        Dictionary<int, bool> dict1 = new Dictionary<int, bool>();
        Dictionary<int, bool> dict2 = new Dictionary<int, bool>();

        // Fill dictionaries with elements from nums1 and nums2
        foreach (var num in nums1)
        {
            if (!dict1.ContainsKey(num))
            {
                dict1[num] = true;
            }
        }
        
        foreach (var num in nums2)
        {
            if (!dict2.ContainsKey(num))
            {
                dict2[num] = true;
            }
        }

        // Find elements in nums1 not in nums2
        IList<int> onlyInNums1 = new List<int>();
        foreach (var num in dict1.Keys)
        {
            if (!dict2.ContainsKey(num))
            {
                onlyInNums1.Add(num);
            }
        }

        // Find elements in nums2 not in nums1
        IList<int> onlyInNums2 = new List<int>();
        foreach (var num in dict2.Keys)
        {
            if (!dict1.ContainsKey(num))
            {
                onlyInNums2.Add(num);
            }
        }

        // Return results as a list of lists
        return new List<IList<int>> { onlyInNums1, onlyInNums2 };
    }
}