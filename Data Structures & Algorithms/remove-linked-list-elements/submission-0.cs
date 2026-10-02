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
   public ListNode RemoveElements(ListNode head , int val)
    {
        var list = IgnoreElementsList(head, val);
        var dummy = new ListNode(0);
        var curr = dummy;

        foreach(var item in list)
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return dummy.next;
    }

    private static List<int> IgnoreElementsList(ListNode head , int val)
    {
        var list = new List<int>();
        var curr = head;
        
        while(curr != null)
        {
            if (curr.val != val)
            {
                list.Add(curr.val);
            }
            curr = curr.next;
        }
        return list;
    }
}