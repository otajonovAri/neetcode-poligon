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
    var list = ListNodeConverterFunc(head);
    var res = MaxMinValue(list);

    var curr = head;
    
    foreach(var item in res)
    {
        curr.val = item;
        curr = curr.next;
    }
}

public List<int> ListNodeConverterFunc(ListNode head)
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

public int[] MaxMinValue(List<int> list)
{
    var maxList = list.OrderByDescending(x => x).ToList();
    var res = new int[maxList.Count()];

    int maxCount = 0, minCount = 0;

    for (int i = 0; i < maxList.Count(); i++)
    {
        if (i % 2 == 0)
            res[i] = list[minCount++];
        else
            res[i] = maxList[maxCount++];
    }

    return res;
}
}
