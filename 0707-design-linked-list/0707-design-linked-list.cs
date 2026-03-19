public class Node{
    public int val;
    public Node next;
    public Node(int val, Node next = null){
        this.val = val;
        this.next = next;
    }
}

public class MyLinkedList {
    Node head;
    int length;
    public MyLinkedList() {
        head = new Node(0);
        length = 0;
    }
    
    public int Get(int index) {
        if (index >= length) return -1;
        Node current = head;
        for (int i = 0; i<index; i++){
            current = current.next;
        }
        return current.next.val;
    }
    
    public void AddAtHead(int val) {
        head.next = new Node(val, head.next);
        length += 1;
    }
    
    public void AddAtTail(int val) {
        Node current = head;
        while(current.next != null){
            current = current.next;
        }
        current.next = new Node(val);
        length += 1;
    }
    
    public void AddAtIndex(int index, int val) {
        if (index > length) return;
        Node current = head;
        for (int i = 0; i<index; i++){
            current = current.next;
        }
        current.next = new Node(val, current.next);
        length += 1;
    }
    
    public void DeleteAtIndex(int index) {
        if (index >= length || length == 0) return;
        Node current = head;
        for (int i = 0; i<index; i++){
            current = current.next;
        }
        current.next = current.next.next;
        length -= 1;
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */