/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        // 分兩個部分：1)有沒有環? 2)環入口在哪?
        // 1) 用快慢指針，如果相遇就代表有環
        // 2) 撞到之後，讓一個指針從頭開始，兩指針一起走，相遇點就是環入口
        //    證明：假設 L 代表起點到環入口， K 代表環入口到快慢指針相遇點，C 代表環的總長
        //          那slow = L+K, fast = L+nC+K => L+nC+K = 2(L+K) => L = nC-K
        //          所以slow再走L步 slow = L+K+(nC-K) = L+nC，fast從頭走L步 fast = L 剛好相遇點即是環入口。
        ListNode fast = head, slow = head;
        while(fast != null && fast.next != null) // fast一定比較快
        {
            fast = fast.next.next;
            slow = slow.next;
            if (fast == slow) // 相遇 => 有環，開始找環入口
            {
                slow = head;
                while(fast != slow)
                {
                    fast = fast.next;
                    slow = slow.next;
                }
                return slow;
            }
        }
        return null; // fast走到底了
    }
}