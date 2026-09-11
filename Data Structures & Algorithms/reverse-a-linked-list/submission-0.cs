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
    public ListNode ReverseList(ListNode head) 
    {
        var current = head;
        var list = new List<int>();

        while(current != null)
        {
            list.Add(current.val);
            current = current.next;
        }   

        var dummy = new ListNode(0);
        current = dummy;

        for(int i = list.Count-1; i>=0; i--)
        {
            current.next = new ListNode(list[i]);
            current = current.next;
        }

        return dummy.next;
    }
}
