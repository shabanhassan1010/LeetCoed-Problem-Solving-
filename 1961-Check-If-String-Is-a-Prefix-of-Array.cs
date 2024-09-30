public class Solution {
    public bool IsPrefixString(string s, string[] words) 
    {
    string prefix = "";
    foreach (string word in words)
    {
        prefix += word;       
        if(prefix == s) return true;
       
    }
    return false;   // Return false if no match is found
    }
}