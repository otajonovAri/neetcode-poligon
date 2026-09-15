public class Solution
{
    public bool IsAnagram(string s, string t)
        => GetDict(s).Count == GetDict(t).Count && GetDict(s).Except(GetDict(t)).Any();

    private Dictionary<char, int> GetDict(string str)
    {
        var dict = new Dictionary<char, int>();
        foreach (var item in str)
        {
            dict.TryAdd(item, 1);
            dict[item]++;
        }

        return dict;
    }
}
