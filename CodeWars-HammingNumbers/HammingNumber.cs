using System.Numerics;
namespace CodeWars_HammingNumbers;

public class HammingNumber
{
    public static long Hamming(int n)
    {
        const int two = 2;
        const int three = 3;
        const int five = 5;
        var hammingNumber = new BigInteger[n];
        hammingNumber[0] = 1;
        BigInteger p2 = 2, p3 = 3, p5 = 5;
        int i = 0, j = 0, k = 0;
 
        for (var index = 1; index < n; index++) 
        {
            hammingNumber[index] = BigInteger.Min(p2, BigInteger.Min(p3, p5));
            if (hammingNumber[index] == p2) p2 = hammingNumber[++i] * two;
            if (hammingNumber[index] == p3) p3 = hammingNumber[++j] * three;
            if (hammingNumber[index] == p5) p5 = hammingNumber[++k] * five;
        }
        return (long)hammingNumber[n - 1];
    }
}
