public class Solution {
    public bool IsSubsequence(string s, string t) {
        if (s.Length == 0) return true;
        if (t.Length == 0 || string.IsNullOrWhiteSpace(t)) return false;

        foreach(var i in s)
        {
            if (t.Contains(i))
            {
                t = t.Substring(t.IndexOf(i) + 1);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}