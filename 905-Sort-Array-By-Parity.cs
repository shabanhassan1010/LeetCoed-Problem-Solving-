public class Solution 
{
    public int[] SortArrayByParity(int[] nums) 
    {
    List<int> st = new List<int>();  

    for (int i = 0; i < nums.Length; i++)    // Add all even numbers first
    {
        if (nums[i] % 2 == 0)
            st.Add(nums[i]);       
    }  

    for (int i = 0; i < nums.Length; i++)    // Add all odd numbers next
    {
        if (nums[i] % 2 != 0)
            st.Add(nums[i]);
    }  
    return st.ToArray();      // Convert the list to an array and return 
    }
}