int[] numbers = {18, -5, 24, -7, 56, -9, 102, -245, 34, -108, 85, -43, 15, -20, 45, -2};
// I intend that the largest negative number is the negative number closest to 0, in this case is -2
int largestNegative = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]<0) //checks if the number is negative
    {
        if (largestNegative == 0 || numbers[i] > largestNegative) //checks if it is the first negative number or the largest negative number
        {
            largestNegative = numbers[i]; // if the if condition is true then assigns the number checked as the largest negative
        }
    }
}
Console.WriteLine(largestNegative);





