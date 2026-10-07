int[] numbers = {1,4,10,34};
int max = numbers[0];
int MaxIndex=0;
for (int i=1; numbers.Length > i; i++)
{
    if (numbers[i]>max)
{
    max = numbers[i];
    MaxIndex=i;
}    
}
Console.WriteLine($"Max Value is: {max} at Index: {MaxIndex}");