/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
        ListNode A = headA, B = headB;
        int a = 0, b = 0;
        while(A.next != null) { a += 1; A = A.next; }
        while(B.next != null) { b += 1; B = B.next; }
        A = headA;
        B = headB;
        if (a>b) for (int i = 0; i<a-b; i++) A = A.next;
        else for (int i = 0; i<b-a; i++) B = B.next;
        while(A != B && A.next != null) {A = A.next; B = B.next;}
        if (A == B) return A;
        else return null;
    }
}