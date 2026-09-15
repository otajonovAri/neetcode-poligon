public class Solution {

    public string Encode(IList<string> strs)
     => string.Join(",", strs);

 public List<string> Decode(string s)
     => s.Split(",").ToList();
}
