
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var resList = GetListConverterFun(list1)
        .Concat(GetListConverterFun(list2))
        .OrderBy(x => x).ToList();

        var dummy = new ListNode(0);
        var curr = dummy;

        foreach(var item in resList)
        {
            curr.next = new ListNode(item);
            curr = curr.next;
        }

        return dummy.next;
    }

    private static List<int> GetListConverterFun(ListNode head)
    {
        var list = new List<int>();
        var curr = head;

        while(curr != null)
        {
            list.Add(curr.val);
            curr = curr.next;
        }

        return list;
    }
}