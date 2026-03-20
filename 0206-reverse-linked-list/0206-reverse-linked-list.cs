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
        // 每次抓一個元素出來，放在虛擬頭的後面。
        ListNode reverseList = new ListNode();
        while(head != null)
        {
            ListNode e = new ListNode(head.val, reverseList.next);
            reverseList.next = e;
            head = head.next;
        }
        return reverseList.next;
    }
}