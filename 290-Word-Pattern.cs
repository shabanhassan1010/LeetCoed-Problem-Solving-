public class Solution 
{
    public bool WordPattern(string pattern, string s) 
    {
        var words = s.Split(" ");
        // The Split method breaks down the string s into individual words, 
        // allowing you to analyze each word separately.
        // Ex: IF s = "dog cat cat dog", then words will be ["dog", "cat", "cat", "dog"].
        if(pattern.Length != words.Length)      // Patter = "abba"  and   s=  ["dog", "cat", "cat", "dog"].
        return false;

        var charToWord = new Dictionary<char, string>();
        var wordToChar = new Dictionary<string, char>();    

        for(int i = 0 ; i < pattern.Length ; i++ )
        {
            char currentChar = pattern[i];
            string currentWord = words[i];

        // Check if there's a conflict in char-to-word mapping
            if (charToWord.ContainsKey(currentChar))
            {
                if (charToWord[currentChar] != currentWord) 
                    return false;            
            }                          
            else       
            charToWord[currentChar] = currentWord;

        // Check if there's a conflict in word-to-char mapping
            if (wordToChar.ContainsKey(currentWord))
            {
                if (wordToChar[currentWord] != currentChar)              
                    return false;              
            }
            else
                wordToChar[currentWord] = currentChar;
        }
                return true;
    }
}