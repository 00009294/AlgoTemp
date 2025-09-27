namespace AlgoTemp
{
    public class ListNode
    {
        public int Value { get; private set; }
        public ListNode Next { get; internal set; }
        public ListNode(int value = 0, ListNode next = null!)
        {
            Value = value;
            Next = next;
        }
    }
}
