public class Solution {
    public bool IsPrefixString(string s, string[] words) {
        string prefix = "";
    
    foreach (string word in words)
    {
        prefix += word;
        
        // If the current prefix matches 's', return true
        if (prefix == s)
            return true;
        
        // If the prefix becomes longer than 's', return false
        if (prefix.Length > s.Length)
            return false;
    }
    
    return false; // Return false if no match is found
    }
}