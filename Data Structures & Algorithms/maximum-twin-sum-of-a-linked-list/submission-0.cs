public class Solution 
{
    public int PairSum(ListNode head) 
    {
        var list = GetListNode(head);
        int maxSum = 0;
        int start = 0, end = list.Count - 1;

        while (start < end) 
        {
            int currentSum = list[start] + list[end];
            if (currentSum > maxSum) 
            {
                maxSum = currentSum;
            }
            start++;
            end--;
        }

        return maxSum;
    }

    private static List<int> GetListNode(ListNode head) 
    {
        var list = new List<int>();
        var curr = head;

        while (curr != null) 
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        return list;
    }
}
