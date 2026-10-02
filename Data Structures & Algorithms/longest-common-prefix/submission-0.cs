public class Solution {
     public string LongestCommonPrefix(string[] strs)
 {
     return CompareTwoString(strs[0], strs[^1]);
 }
 private static string CompareTwoString(string str1, string str2)
 {
     int index = 0, minLen = (int)MathF.Min(str1.Length, str2.Length);

     var str = "";

     while(minLen != index)
     {
        if (str1[index] == str2[index])
             str += str1[index].ToString();
        else 
            break;

         index++;
     }

     return str;
 }
}