public class Solution {
     public int FirstUniqChar(string s)
 {
     var dict = CharCounterFunc(s);
     return s.IndexOf(dict.Where(x => x.Value == 1).FirstOrDefault().Key);
 }
 private static Dictionary<char,int> CharCounterFunc(string str)
 {
     var dict = new Dictionary<char, int>();
     foreach (var item in str)
         dict[item] = dict.GetValueOrDefault(item, 0) + 1;
     return dict;
 }
}