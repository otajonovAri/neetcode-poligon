public class Solution {
    public bool IsValid(string s) {
        int count = 0;
        foreach (var item in s)
        {
            if(item == '(' || item == '[' || item == '{')
                count++;
            else if(item == ')' || item == ']' || item == '}')
                if(count == 0)
                    return false;
            else 
                count--;
        }
        
        return count == 0;
    }
}
