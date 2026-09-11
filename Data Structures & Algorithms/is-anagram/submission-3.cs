public class Solution
{
    public bool IsAnagram(string s, string t)
        => SortStrings(s) == SortStrings(t);

    private string SortStrings(string str)
    {
        var chars = str.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}
