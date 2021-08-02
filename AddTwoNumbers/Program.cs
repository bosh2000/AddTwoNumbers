using System;

namespace AddTwoNumbers
{
    public class Program
    {
        private static void Main(string[] args)
        {
            ListNode listNode1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode listNode2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            ListNode listNode = AddTwoNumbers(listNode1, listNode2);
            while (true)
            {
                Console.WriteLine(listNode.val);
                if (listNode.next == null) break;
                listNode = listNode.next;
            }
            Console.ReadLine();
        }

        public static ListNode AddTwoNumbers(ListNode listNode1, ListNode listNode2)
        {
            ListNode returnListNode = new ListNode();
            ListNode currentListNode = returnListNode;
            int carry = 0;
            while (listNode1 != null || listNode2 != null)
            {
                int sum = carry + listNode1.val + listNode2.val;
                carry = sum / 10;
                currentListNode.next = new ListNode(sum % 10);
                currentListNode = currentListNode.next;
                listNode1 = listNode1.next;
                listNode2 = listNode2.next;
            }
            if (carry > 0)
            {
                currentListNode.next = new ListNode(carry);
            }
            return returnListNode.next;
        }
    }
}