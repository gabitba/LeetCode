namespace LeetCode.Problems
{
    /*
     * You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
     * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
     * 
     * Example:
     * Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
     * Output: 7 -> 0 -> 8
     * Explanation: 342 + 465 = 807.
     * 
    */

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            return AddTwoNumbersRecursive(l1, l2, false);
        }

        private static ListNode AddTwoNumbersRecursive(ListNode listNode1, ListNode listNode2, bool plusOne)
        {
            if (listNode1 != null || listNode2 != null)
            {
                int sum = (listNode1?.val ?? 0) + (listNode2?.val ?? 0) + (plusOne ? 1 : 0);

                ListNode result = new ListNode(sum >= 10 ? sum - 10 : sum);

                result.next = AddTwoNumbersRecursive(listNode1?.next, listNode2?.next, sum >= 10);

                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
