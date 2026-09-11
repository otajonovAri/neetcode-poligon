public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        // First pass to get the length
        int length = 0;
        var current = head;
        while (current != null)
        {
            length++;
            current = current.next;
        }

        // If removing the head
        if (n == length)
            return head.next;

        // Second pass to find the node before the one to remove
        current = head;
        for (int i = 1; i < length - n; i++)
        {
            current = current.next;
        }

        // Remove the target node
        current.next = current.next?.next;

        return head;
    }
}
