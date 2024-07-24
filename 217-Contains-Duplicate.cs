public class Solution 
{
   public bool ContainsDuplicate(int[] nums)
{
   HashSet<int> set = new HashSet<int>();
   for(int i = 0 ; i < nums.Length ; i++)
   {
    int res = nums[i];
    if(!set.Add(res)) // If the element res is already in the HashSet, the Add method returns false, indicating a duplicate. In this case, the function returns true
    {
        return true;
    }
   }
   return false;
}

}