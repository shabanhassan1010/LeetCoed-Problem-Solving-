public class Solution {
    public int DifferenceOfSum(int[] nums)
    {    
    int sum = 0;        // To hold the sum of the elements
    int sumDigits = 0;  // To hold the sum of all digits

    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];  // Add the number to the element sum
        
        // Calculate the sum of digits of nums[i]
        int temp = nums[i];
        while (temp > 0)
        {
            sumDigits += temp % 10;  // Add the last digit
            temp /= 10;              // Remove the last digit
        }
    }

    // Return the absolute difference between the element sum and digit sum
    return sum -  sumDigits;
    }
}