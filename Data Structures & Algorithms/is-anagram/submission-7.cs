public class Solution {
    public bool IsAnagram(string s, string t)
{
    var ans = new int[26];

    for (int i = 0; i < s.Length; i++)
    {
        ans[s[i] - 'a']++;
        ans[t[i] - 'a']--;
    }

    foreach(var item in ans)
        if (item == 0)
            return true;

    return false;
}
}
