Console.WriteLine("Calculating...");
Console.WriteLine($"Result: {Subtraction(4, -3)}");


int Subtraction(int a, int b)
{
    int aComplemented = ~a + 1;
    int bComplemented = ~b + 1;

    Console.WriteLine(Convert.ToString(aComplemented, 2));
    Console.WriteLine(Convert.ToString(bComplemented, 2));
    
    return ~(aComplemented + bComplemented) + 1;
}