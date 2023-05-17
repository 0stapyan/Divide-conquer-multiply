
var gamer = new BigInteger("123456789").ToString();
public class BigInteger
{
    private int[] _numbers;
    private string _numbersToString;

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
    
    public override string ToString()
    {
        foreach (var gamer in _numbers)
        {
            _numbersToString += gamer;
        }
        
        Console.WriteLine(_numbersToString);

        return _numbersToString;
    }
}
