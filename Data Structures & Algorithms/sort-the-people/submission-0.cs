public class Solution {
     public string[] SortPeople(string[] names , int[] heights)
     => GetDict(heights, names).OrderByDescending(x => x.Key).Select(x => x.Value).ToArray();
    private static Dictionary<int,string> GetDict(int[] prog, string[] names)
    {
        var dict = new Dictionary<int, string>();
        var index = 0;
        foreach (var item in prog)
            dict[item] = names[index++];
        return dict;
    }
}