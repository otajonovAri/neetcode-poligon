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
     var dummy = new ListNode(0);
     var curr = dummy;

     foreach (var item in GetList(head))
     {
         curr.next = new ListNode(item);
         curr = curr.next;
     }

     return dummy.next;
 }

 private List<int> GetList(ListNode head)
 {
     var curr = head;
     var list = new List<int>();

     while (curr != null)
     {
         list.Add(curr.val);
         curr = curr.next;
     }

     list.Reverse();

     return list;
 }
}
