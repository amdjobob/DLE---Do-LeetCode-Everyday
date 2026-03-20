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
    public ListNode SwapPairs(ListNode head) {
        ListNode cur = new ListNode(0, head), pre = cur, temp;
        head = cur;
        int count = 0;
        while(cur.next != null)
        {
            count += 1;
            temp = pre;
            pre = cur;
            cur = cur.next;
            if (count == 2)
            {
                ListNode nextTemp = cur.next;
                temp.next = cur;
                cur.next = pre;
                pre.next = nextTemp;
                cur = pre;
                count = 0;
            }
        }
        return head.next;
    }
}