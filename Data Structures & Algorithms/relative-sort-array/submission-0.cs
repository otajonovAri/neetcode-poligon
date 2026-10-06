public class Solution {
   public int[] RelativeSortArray(int[] arr1 , int[] arr2)
{
    var dict = GetDictCount(arr1);
    var list = new List<int>();
    var notContains = NotContains(arr1 ,arr2);


    foreach (var item in arr2)
        ForArrayInValue(item, dict.Where(x => x.Key == item).FirstOrDefault().Value, list);

    list.AddRange(notContains);

    return list.ToArray();
}
private static List<int> NotContains(int[] arr1, int[] arr2)
{
    var list = new List<int>();
    foreach (var item in arr1)
        if (!arr2.Contains(item))
            list.Add(item);

    list.Sort();

    return list;
}
private static void ForArrayInValue(int item , int kai , List<int> list)
{
    for (int i = 1; i <= kai; i++)
        list.Add(item);
}

private static Dictionary<int,int> GetDictCount(int[] nums)
{
    var dict = new Dictionary<int, int>();
    foreach (var item in nums)
        dict[item] = dict.GetValueOrDefault(item, 0) + 1;

    return dict;
}
}