public class Solution {
    public bool IsPalindrome(string s) {
         string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            if(char.IsSymbol(s[i]) || char.IsWhiteSpace(s[i]) || char.IsPunctuation(s[i]))
                continue;
            res += char.ToLower(s[i]);
        }

        string reverse = "";
        for(int i = res.Length - 1; i >= 0; i--)    
            reverse += res[i];
        
        
        return res == reverse;
    }
}
