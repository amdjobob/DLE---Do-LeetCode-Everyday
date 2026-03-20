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
        // 解題思路：雙指針(快慢指針)
        // 每次交換有兩件事：
        // 1) 交換
        // 2) 接回鏈路：頭要指向交換完的快指針，慢指針交換完要指向尾
        ListNode cur = new ListNode(0, head), pre = cur, temp;
        head = cur;
        int count = 0;
        while(cur.next != null)
        {
            count += 1;     // 計數器
            temp = pre;     // 超慢指針：交換完之後，把 linklsit 重新接上。
            pre = cur;      // 慢指針
            cur = cur.next; // 快指針
            if (count == 2)
            {
                ListNode nextTemp = cur.next; // 超快指針：也是交換完，把 linklist 重新接上
                cur.next = pre;               // 交換：快指針的 next 指向慢指針
                temp.next = cur;              // 頭指向快指針
                pre.next = nextTemp;          // 慢指針指向尾
                cur = pre;                    // 因為交換，快慢指針需要換回來
                count = 0;
            }
        }
        return head.next;
    }
}