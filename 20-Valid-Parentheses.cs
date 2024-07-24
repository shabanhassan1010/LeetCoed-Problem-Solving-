public class Solution
 {
     public bool IsValid(string s) 
    {
        Stack<char> result = new();

        foreach(char character in s)
        {
            if (character.Equals ('(') || character.Equals ('[') || character.Equals ('{'))
                result.Push(character);

            if (result.Count > 0)
            {
                if (character.Equals (')') && !result.Pop().Equals ('('))
                    return false;

                if (character.Equals(']') && !result.Pop().Equals ('['))
                    return false;

                if (character.Equals('}') && !result.Pop().Equals ('{'))
                    return false;
            }
            else 
                return false;     
        }
        
        if(result.Count != 0)
            return false;

        return true;
    }
}