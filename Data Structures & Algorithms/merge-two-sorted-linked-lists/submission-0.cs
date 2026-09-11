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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var a = GetListConvert(list1);
        var b = GetListConvert(list2);

        var doubleList = a.Concat(b).ToArray();
        Array.Sort(doubleList);

        var dummy = new ListNode(0);
        var current = dummy;

        foreach(var item in doubleList)
        {
            current.next = new ListNode(item);
            current = current.next;
        }

        return dummy.next;
    }
    private List<int> GetListConvert(ListNode head)
    {
        var current = head;
        var list = new List<int>();

        while(current != null)
        {
            list.Add(current.val);
            current = current.next;
        }

        return list;
    }
}