public class Solution
{

    public string Encode(IList<string> strs)
    {
        if(strs.Count == 0) return "";
        return string.Join(",", strs);
    }

    public List<string> Decode(string s)
    {
        if(s.Length == "") return [];
        return s.Split(',').ToList();
    }
}
