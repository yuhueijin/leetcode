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
        var current = head;
        var count = 0;
        while (current != null)
        {
            count++;
            current = current.next;
        }
        var removePos = count - n;
        current = head;
        if (removePos == 0)
        {
            return current?.next == null ? null : current.next;
        }
        var currentPos = 1;
        while (current != null)
        {
            if (currentPos == removePos)
            {
                current.next = current.next.next;
                break;
            }
            current = current.next;
            currentPos++;
        }
        return head;
    }
}