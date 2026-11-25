/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
 
public class Solution {
    public ListNode ModifiedList(int[] nums, ListNode head)
    {
        var list = GetLogView(head,nums);
        var dummy = new ListNode(0);
        var curr = dummy;

        foreach(var item in list)
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return dummy.next;
    }
    private static List<int> GetLogView(ListNode head , int[] nums)
    {
        var list = new List<int>();
        var dict = GetDict(GetListConverter(head));

        foreach(var item in dict)
        {
            if(!nums.Contains(item.Key))
            {
                for(int i = 1; i <= item.Value; i++)
                {
                    list.Add(item.Key);
                }
            }
        }

        return list;
    }
    private static Dictionary<int,int> GetDict(List<int> list)
    {
        var dict = new Dictionary<int,int>();
        foreach(var item in list)
            dict[item] = dict.GetValueOrDefault(item , 0) + 1;

        return dict;
    }
    private static List<int> GetListConverter(ListNode head)
    {
        var list = new List<int>();
        var curr = head;

        while(curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        return list;
    }
}
