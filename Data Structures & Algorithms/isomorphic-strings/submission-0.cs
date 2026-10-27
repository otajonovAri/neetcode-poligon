public class Solution {
   public bool IsIsomorphic(string s, string t)
    {
        var sDict = new Dictionary<char, int>();
        var tDict = new Dictionary<char, int>();
        
        GetCharCounter(s,sDict);
        GetCharCounter(t,tDict);
        
        return sDict.Count() == tDict.Count();
    }

    private static void GetCharCounter(string s, Dictionary<char, int> dict)
    {
        foreach (var item in s)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;
    }
}