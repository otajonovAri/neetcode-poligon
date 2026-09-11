public class Solution
{
    public int Reverse(int x)
    {
        var str = x.ToString();
        if (str[0] == '-')
        {
            str = "-" + new string(str.Substring(1).Reverse().ToArray());
        }
        else
        {
            str = new string(str.Reverse().ToArray());
        }
        
        return int.TryParse(str, out int result) ? result : 0;
    }
}
