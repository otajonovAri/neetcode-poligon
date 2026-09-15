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
    public ListNode ReverseKGroup(ListNode head, int k) {
        
        var list = new List<int>();
        var current = head;

        while(current != null)
        {
            list.Add(current.val);
            current = current.next;
        }

        var start = list.Take(k).ToList();
        var end = list.Skip(k).ToList();
        if(start.Count >= 3)
            start.Reverse(); 
        if(end.Count >= 3)
            end.Reverse();

        var doubleList = start.Concat(end);
        var dummy = new ListNode(0);
        current = dummy;

        foreach(var item in doubleList)
        {
            current.next = new ListNode(item);
            current = current.next;
        }


        return dummy.next;
    }
}
