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

public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        var listNode = new ListNode();
        var current = listNode;
        var minHeap = new SortedSet<(int value, int index)>();
        for (int i = 0; i < lists.Length; i++)
        {
            if (lists[i] != null)
            {
                minHeap.Add((lists[i].val, i));
            }
        }
        while (minHeap.Count > 0)
        {
            var (value, index) = minHeap.Min;
            minHeap.Remove(minHeap.Min);
            current.next = new ListNode(value);
            current = current.next;
            lists[index] = lists[index].next;
            if (lists[index] != null)
            {
                minHeap.Add((lists[index].val, index));
            }
        }
        return listNode.next;
    }
}
