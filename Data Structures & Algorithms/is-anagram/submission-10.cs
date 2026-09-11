public class Solution {
    public bool IsAnagram(string s, string t)
{
    if(s.Length != t.Length) return false;
    var ans = new int[26];

    for (int i = 0; i < s.Length; i++)
    {
        ans[s[i] - 'a']++;
        ans[t[i] - 'a']--;
    }

    if (ans.Any(x => x != 0)) return false;

    return true;
}
}
