public class BigInteger
{
    private int[] _numbers;

    public BigInteger(string value)
    {
        int length = value.Length;
        
        _numbers = new int[length];
        
        for (int i = 0; i < length; i++)
        {
            int digit = value[length - 1 - i] - '0';
            
            _numbers[i] = digit;
        }
    }
}
