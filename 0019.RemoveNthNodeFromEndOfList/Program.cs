// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var solution = new Solution();
var head = new ListNode(1, new ListNode(2));
var n = 2;
var result = solution.RemoveNthFromEnd(head, n);
Console.WriteLine(result.val);

// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var dummy = new ListNode(0, head);
        var first = dummy;
        var second = dummy;
        for (int i = 0; i < n + 1; i++)
        {
            first = first.next;
        }

        while (first != null)
        {
            first = first.next;
            second = second.next;
        }
        second.next = second.next.next;
        return dummy.next;
    }
}