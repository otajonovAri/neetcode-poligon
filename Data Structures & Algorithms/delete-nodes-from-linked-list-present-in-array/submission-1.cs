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
        var numSet = new HashSet<int>(nums);
        var dummy = new ListNode(0);
        dummy.next = head;
        var curr = dummy;

        while (curr.next != null)
        {
            if (numSet.Contains(curr.next.val))
            {
                curr.next = curr.next.next;
            }
            else
            {
                curr = curr.next;
            }
        }

        return dummy.next;
    }
}