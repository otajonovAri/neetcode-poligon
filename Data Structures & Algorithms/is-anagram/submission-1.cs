public class Solution {
     public bool IsAnagram(string s, string t)
    {
        var dictS = ToDict(s);
        var dictT = ToDict(t);
        foreach(var item in dictS)
        {
            if (!dictT.TryGetValue(item.Key, out int count))
                return false;
            if (item.Value != count)
                return false;
        }
        return true;
    }

    static Dictionary<char, int> ToDict(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach (var item in s)
        {
            dict.TryGetValue(item , out int count);
            dict[item] = count + 1;
        }
        return dict;
    }
}
