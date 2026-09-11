public class Solution {
    public List<List<string>> GroupAnagrams(string[] str)
{
    var res = new List<List<string>>();

    foreach (var item in str)
    {
        var groupList = GroupStringList(str);

        foreach (var group in groupList)
            res.Add(group.Value);
        
        return res;
    }

    return new List<List<string>>();
}

private static Dictionary<string, List<string>> GroupStringList(string[] strings)
{
    var groupList = new Dictionary<string, List<string>>();

    foreach(var item in strings)
    {
        var key = string.Concat(item.OrderBy(c => c));
        if (!groupList.ContainsKey(key))
            groupList[key] = new List<string>();
        groupList[key].Add(item);
    }

    return groupList;
}
}
