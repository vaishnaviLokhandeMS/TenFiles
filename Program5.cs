using System;

namespace MyCSharpProject
{
    // Definition for singly-linked list node
    public class ListNode
    {
        public int Val;
        public ListNode Next;

        public ListNode(int val = 0, ListNode next = null)
        {
            Val = val;
            Next = next;
        }
    }

    class Program5
    {
        // Function to reverse a linked list
        public static ListNode ReverseLinkedList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;

            while (current != null)
            {
                ListNode next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            return prev;
        }

        // Function to detect a cycle in a linked list using Floyd's Cycle-Finding Algorithm
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.Next == null)
                return false;

            ListNode slow = head;
            ListNode fast = head.Next;

            while (fast != null && fast.Next != null)
            {
                if (slow == fast)
                    return true;

                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return false;
        }

        static void Main(string[] args)
        {
            // Creating a linked list: 1 -> 2 -> 3 -> 4 -> 5
            ListNode head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(5);

            // Printing original linked list
            Console.WriteLine("Original Linked List:");
            PrintLinkedList(head);

            // Reversing the linked list
            ListNode reversedHead = ReverseLinkedList(head);

            // Printing reversed linked list
            Console.WriteLine("Reversed Linked List:");
            PrintLinkedList(reversedHead);

            // Creating a cycle in the linked list: 1 -> 2 -> 3 -> 4 -> 5 -> 3 (cycle back to 3)
            head = new ListNode(1);
            ListNode second = new ListNode(2);
            ListNode third = new ListNode(3);
            ListNode fourth = new ListNode(4);
            ListNode fifth = new ListNode(5);

            head.Next = second;
            second.Next = third;
            third.Next = fourth;
            fourth.Next = fifth;
            fifth.Next = third; // Creating a cycle here

            // Detecting cycle in the linked list
            bool hasCycle = HasCycle(head);
            Console.WriteLine($"Linked List has cycle: {hasCycle}");
        }

        // Utility function to print the linked list
        static void PrintLinkedList(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.Val + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
