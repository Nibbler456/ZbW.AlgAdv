namespace FloatingPoint.Tests;
[TestClass]
public sealed class FloatingPointAdditionHelperMethodsTests
{
    private int value = BitConverter.SingleToInt32Bits(0b10000000100000000000000000000001);
    
    [TestMethod]
    public void TestBitExtractionSigningBit()
    {
        int signingBitStartPosition = 31;
        int signingBitSize = 1;
        

        int resultSigningBit = FloatingPointAddition.ExtractBits(value, signingBitStartPosition, signingBitSize);

        Assert.AreEqual(0b1, resultSigningBit);
        
    }
    
    [TestMethod]
    public void TestBitExtractionExponentBits()
    {
        int exponentBitsStartPosition = 30;
        int exponentBitsSize = 8;
        
        int resultExponentBits = FloatingPointAddition.ExtractBits(value, exponentBitsStartPosition, exponentBitsSize);
       
        Assert.AreEqual(0b00000001, resultExponentBits);
    }
    
    [TestMethod]
    public void TestBitExtractionMantissaBits()
    {
        int mantissaStartPosiiton = 22;
        int mantissaSize = 23;
        
        int resultMantissaBits = FloatingPointAddition.ExtractBits(value, mantissaStartPosiiton, mantissaSize);
        
        Assert.AreEqual(0b00000000000000000000001, resultMantissaBits);
    }
}