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
    public ListNode ReverseList(ListNode head) {
        // 使用雙指針法，不用每次都 new 新物件出來
        ListNode pre = null, cur = head;
        while(cur != null)
        {
            ListNode nextTemp = cur.next; // 其實是三指針，先把下一個元素位置存起來，防止斷鏈
            cur.next = pre;               // 轉向
            pre = cur;                    // 移動指針，同下
            cur = nextTemp;
        }
        return pre; // 不是return cur，因為最後一次 cur 是最後一個物件的 next 是空的。
    }
}