namespace prjBasicLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node n = new Node(6);
            Node na = new Node(7);
            Node nb = new Node(8);
            n.next = na;
            na.previous = n;
            na.next = nb;
            nb.previous = na;
            Console.WriteLine("Size of the list is {0}"
                ,countNode(n));
        }
        public static int countNode(Node Head)
        {
            int count = 1;
            Node current = Head;
            while (current.next != null)
            {
                current = current.next;
                count++;
            }
            return count;
        }
        public static Node GetLast(Node Head)
        {
            Node last = Head;
            while(last.next != null)
            {
                last = last.next;
            }
            return last;
        }
        public static Node GetFirst(Node Middle)
        {
            Node first = Middle;
            while(first.previous != null)
            {
                first = first.previous;
            }
            return first;
        }
        public static Node FindNode(int Value,Node Head)
        {
            Node Current = Head;
            while(Current.next != null)
            {
                if(Current.value == Value)
                {
                    return Current;
                }
            }
            return null;
        }
        public static Node AddNode(Node Add,Node Current)
        {
            Add.previous = Current;
            Add.next = Current.next;
            Current.next = Add;
            return Current;
        }
        //Print out whole list 

        //Find inside the list and indicate that spot and show hole list

        //Create a call to create your nodes in

    }
}