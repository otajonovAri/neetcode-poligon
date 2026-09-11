public class Solution {
     public bool IsAnagram(string s, string t)
    {
        return SortString(s) == SortString(t);
    }

    static string SortString(string s)
    {
        var chars = s.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}
