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
        ListNode current = head, previous = head;
        while( head != null && head.val == val )
        {
            head = head.next;
        }
        while(true)
        {
            if (current == null) return head;
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
    }
}