using System;

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

public class AddTwoNumbers
{
    public ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0);
        ListNode p = l1, q = l2, curr = dummyHead;
        int carry = 0;

        while (p != null || q != null)
        {
            int x = (p != null) ? p.val : 0;
            int y = (q != null) ? q.val : 0;
            int sum = carry + x + y;
            carry = sum / 10;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;
            if (p != null) p = p.next;
            if (q != null) q = q.next;
        }

        if (carry > 0)
        {
            curr.next = new ListNode(carry);
        }

        return dummyHead.next;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // 1️⃣ Misol uchun ikkita sonni ro‘yxat sifatida beramiz: (2 -> 4 -> 3) va (5 -> 6 -> 4)
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        AddTwoNumbers solution = new AddTwoNumbers();
        ListNode result = solution.AddTwoNumbersMethod(l1, l2);

        Console.Write("Natija: ");
        while (result != null)
        {
            Console.Write(result.val);
            if (result.next != null) Console.Write(" -> ");
			result = result.next;
		}
        Console.WriteLine();
    }
}
