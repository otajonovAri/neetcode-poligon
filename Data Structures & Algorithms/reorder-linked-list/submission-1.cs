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
   public void ReorderList(ListNode head)
{
    var list = new List<int>();
    GetListConverter(list, head);
    int left = 0, right = list.Count() - 1;
    var curr = head;

    while (left <= right)
    {
        curr.val = list[left];
        curr = curr.next;
        if (left != right)
        {
            curr.val = list[right];
            curr = curr.next;
        }

        left++; right--;
    }
}

private static void GetListConverter(List<int> list , ListNode head)
{
    while(head != null)
    {
        list.Add(head.val);
        head = head.next;
    }
}
}