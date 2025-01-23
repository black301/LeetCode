    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode listNode = new ListNode();
            ListNode result = listNode;
            while (l1 != null || l2 != null)
            {
                listNode.next = new ListNode();
                listNode = listNode.next;
                int value = carry;
                carry = 0;
                if (l1 != null)
                {
                    value += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    value += l2.val;
                    l2 = l2.next;
                }
                if (value < 9)
                {
                    listNode.val = value; 
                }
                else
                {
                    listNode.val = value % 10;
                    carry = (value / 10);
                }
            }
            if (carry != 0)
            {
                listNode.next = new ListNode(carry);
            }
            return result.next;
        }
    }
    