public class Solution {
        private bool Helper(string s, string t) {
        Dictionary<char, char> mp = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++) {
            if (mp.ContainsKey(s[i]) && mp[s[i]] != t[i]) {
                return false;
            }
            mp[s[i]] = t[i];
        }
        return true;
    }

    public bool IsIsomorphic(string s, string t) {
        return Helper(s, t) && Helper(t, s);
    }
}