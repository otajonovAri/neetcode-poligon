public class Solution {
     public string LongestCommonPrefix(string[] strs)
 {
     return CompareTwoString(strs[0], strs[^1] , strs);
 }
 private static string CompareTwoString(string str1, string str2 , string[] strs)
 {
     int index = 0, minLen = (int)MathF.Min(str1.Length, str2.Length);

     var str = "";

     while(minLen != index)
     {
         if (str1[index] == str2[index] && CheckingIndexChars(index , str1[index] , strs))
             str += str1[index].ToString();
         else
             break;

         index++;
     }

     return str;
 }

 private static bool CheckingIndexChars(int index , char character , string[] strs)
 {
     foreach (var item in strs)
         if (item[index] != character)
             return false;

     return true;
 }
}