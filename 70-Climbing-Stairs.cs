public class Solution 
{
    public int ClimbStairs(int n) 
    {
        // Base cases
        if (n == 1) return 1;
        if (n == 2) return 2;

        // Initialize variables for the first two steps
        int oneStep = 2; // This is for n = 2
        int twoStep = 1; // This is for n = 1
        int current = 0;

        // Calculate the number of ways from step 3 to n
        for (int i = 3; i <= n; i++)
        {
            current = oneStep + twoStep; // 1 + 2 = 3
            twoStep = oneStep;  // now twoStep == 2
            oneStep = current;  // now oneStep == 3
        }
        return current;
    }
}