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
        // 思路：讓兩 linked-lists 從相同的長度出發
        ListNode A = headA, B = headB;
        int a = 0, b = 0;
        while(A.next != null) { a += 1; A = A.next; } // 計算 A 的長度
        while(B.next != null) { b += 1; B = B.next; } // 計算 B 的長度
        A = headA;
        B = headB;
        if (a>b) for (int i = 0; i<a-b; i++) A = A.next; // 如果 A 比較長，讓 A 先走
        else for (int i = 0; i<b-a; i++) B = B.next;     // 如果 B 比較長，讓 B 先走
        while(A != B && A.next != null) {A = A.next; B = B.next;} // 兩個一起走，直到相同的節點
        if (A == B) return A;  // 找到了，回傳相遇的點
        else return null;
    }
}