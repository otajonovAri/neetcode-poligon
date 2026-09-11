public class Solution {
    public bool IsValid(string s) {
         Stack<char> stack = new Stack<char>();
        foreach (var item in s)
        {
            if (item == '(' || item == '[' || item == '{')
            {
                stack.Push(item);
            }
            else
            {
                if(stack.Count == 0)
                    return false;
                var top = stack.Pop();
                if(item == ')' && top != '(' || item == ']' && top != '[' || item == '}' && top != '{')
                    return false;
            }
        }
        
        return stack.Count == 0;
    }
}
