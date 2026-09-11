public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length || string.IsNullOrWhiteSpace(s) || string.IsNullOrWhiteSpace(t))
            return false;

        var dict1 = KeyValuePair(s);
        var dict2 = KeyValuePair(t);

        foreach(var item in dict1)
            if(!dict2.ContainsKey(item.Key) || dict2[item.Key] != item.Value)
                return false;

        return true;
    }

    private static Dictionary<char, int> KeyValuePair(string str)
    {
        var dict = new Dictionary<char, int>();
        foreach (var item in str)
            dict[item] = dict.GetValueOrDefault(item, 0) + 1;

        return dict;
    }
}
