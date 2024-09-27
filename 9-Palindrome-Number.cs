public class Solution {
    public bool IsPalindrome(int x) 
    {
       string s = x.ToString(); // converts the integer x into a string s
       //converts the string into an array of characters so that we can reverse it.
       char[] ConvertStringIntoArray = s.ToCharArray(); 
       Array.Reverse(ConvertStringIntoArray); // Reverse My Charactar Array
       //create a new string from the reversed character array using 
       string reversed = new string(ConvertStringIntoArray);
       // Check if the reversed string is equal to the original
       if(reversed == s) return true;
       else              return false;
    }
}