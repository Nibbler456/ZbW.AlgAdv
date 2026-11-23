namespace FloatingPoint;

public class FloatingPointAddition
{
    public static int ExtractBits(int bits, int start, int numberOfBits)
    {
        //int getToStartBit = bits << start - 1;
        int extractedBits = bits >>> start - numberOfBits;
        return extractedBits;
    }

    private static int ShiftMantissa(int mantissa, int numberOfBitsToShift)
    {
        int shiftedMantissa;
        
        if (numberOfBitsToShift > 0)
        {
            shiftedMantissa = mantissa >>> numberOfBitsToShift;
        }
        else
        {
            shiftedMantissa = mantissa << numberOfBitsToShift;
        }

        return shiftedMantissa;
    }

    private static void PrependLeadingOneForMantissa(int mantissa, int commas, int exponent)
    {
        
    }

    private static void GetSignFromBit()
    {
        
    }

    private static void GetNumberOfBitShiftsForMantissaNormalization()
    {
        
    }

    private static void NormalizeMantissa()
    {
        
    }

    private static void AdjustExponent()
    {
        
    }



    public static void RemoveLeadingOneFromMantissa()
    {
        
    }
    
    private static void AssembleBitsToFloat()
    {
        
    }
    
    public static int Addition(int val1, int val2)
    {
        return 0;
    }
    
    
}