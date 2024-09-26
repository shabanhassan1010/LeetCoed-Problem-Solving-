public class Solution {
    public bool IsPowerOfFour(int n) {
        // Any number less than or equal to 0 can't be a power of three
        if (n <= 0)             return false;     
        // Keep dividing n by 3 while it's divisible by 3
        while (n % 4 == 0) 
        {
            n /= 4;  // n = n / 3
        }   
        // If n becomes 1, then it's a power of three
        return n == 1;  
    }
}