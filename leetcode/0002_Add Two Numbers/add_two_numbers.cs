namespace leetcode._0002_Add_Two_Numbers
{
    /*
     You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse 
     order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

     You may assume the two numbers do not contain any leading zero, except the number 0 itself.

     Example:
     
     Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
     Output: 7 -> 0 -> 8
     Explanation: 342 + 465 = 807.
         */
    public class add_two_numbers
    {
        public class ListNode
        {
            public int val;

            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        /// <summary>
        /// Time Complexity O(max(m,n))  Space Complexity O(max(m,n))
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //initialize current node to dummy head of the returning list
            ListNode dummyHead = new ListNode(0);
            var curr = dummyHead;
            //initial carry to 0
            int carry = 0;
            //loop through lists l1 and l2 until you reach both ends,and carry<1
            while (carry>0|| l1 != null || l2 != null)
            {
                /*
                 set x to node l1's value.if l1 has reached the end of l1,set to 0.
                 set y to node l2's value.if l2 has reached the end of l2,set to 0.
                 set sum=x+y+carry.
                 */
                int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
                //update carry=sum/10
                carry = sum / 10;
                //create a new node with the digit value of (sum mod 10) and
                // set it to current node's next,then 
                curr.next = new ListNode(sum % 10);
                //advance current node to next.
                curr = curr.next;
                //advance both l1 and l2
                l1 = l1?.next;
                l2 = l2?.next;
            }
            //return dummy's next node
            return dummyHead.next;
        }
    }
}
