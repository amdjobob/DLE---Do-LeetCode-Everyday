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
    public ListNode RemoveElements(ListNode head, int val) {
        ListNode previous = head, current = head;
        while(true)
        {
            if (current == null) return head;
            if (head.val == val) head = head.next;
            if (current.val == val) 
            {
                previous.next = current.next;
                current = current.next;
            }
            else 
            {
                previous = current;
                current = current.next;
            }
        }
        // if (head == null) return head;
        // while(head.val == val)
        // {
        //     head = head.next;
        //     if (head == null) return head;
        // }
        // ListNode current = head;
        // while(true)
        // {
        //     if (current == null || current.next == null) return head;
        //     if (current.next.val == val) current.next = current.next.next;
        //     else current = current.next;
        // }
        // return head;
    }
}