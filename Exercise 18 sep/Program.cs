double[] doubleArray = new double[12];
double total = 0;
double average;
int i;


for (i = 0; i < doubleArray.Length; i++) {
    Console.Write("Enter number " + (i + 1) + ": ");
    doubleArray[i] = Convert.ToDouble(Console.ReadLine());
    total += doubleArray[i];
}


average = total / doubleArray.Length;
Console.WriteLine("The average is: " + average);