
public class Solution {
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null || head.next == null || k == 0)
            return head;

        var list = new List<int>();
        var curr = head;

        while (curr != null) {
            list.Add(curr.val);
            curr = curr.next;
        }

        int n = list.Count;
        k = k % n;

        var dummy = new ListNode(0);
        curr = dummy;

        for (int i = 0; i < n; i++) {
            int index = (i - k + n) % n;
            curr.next = new ListNode(list[index]);
            curr = curr.next;
        }

        return dummy.next;
    }
}
