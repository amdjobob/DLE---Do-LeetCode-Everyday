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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        // 解題思路：讓前後指針，間隔n格
        ListNode dummy = new ListNode(0, head), fast = head, slow = dummy;
        int length = 0;
        while(fast != null)
        {
            fast = fast.next;
            slow = slow.next;
            if (++length == n)  // 走了 n 步之後，重製慢指針
            {
                slow = dummy;
            }
        }
        if (n <= length) slow.next = slow.next.next;
        return dummy.next;
    }
}