public class Solution
{
    public string Multiply(string num1, string num2)
    {
        long a = long.Parse(num1);
        long b = long.Parse(num2);
        
        return (a * b).ToString();
    }
}