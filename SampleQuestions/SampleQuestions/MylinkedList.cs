using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestions
{
   public class MySinglelinkedList
    {
        Node start;
        public void reverse()
        {
            Node p1 = null;
            Node p2 = start;
            Node tem;
            while(p2!=null)
            {
                tem=p1;
                p1=p2;
                p2=p2.next;
                p1.next=tem; 
            }
            start = p1;
        }
        public void recursiveReverse()
        {
            recursiveReverse(null, start);
        }
        public void recursiveReverse(Node n1,Node n2)
        {
            if (n2 == null)
            {
                start= n1;
                return;
            }
            Node temp = n2;
            n2 = n2.next;
            temp.next = n1;
            n1 = temp;
            recursiveReverse(n1, n2);
        }
        public void insertAt(Node n,int pos)
        {
            Node temp = start;
            int counter=1;
            while((temp!=null)&&(counter++<pos))
            {
                temp = temp.next;
            }

        }
        public void insertFirst(int a)
        {
            Node tem = start;
            Node n = new Node(a);
            n.next = start;
            start = n;       
        }
        public void insertLast(int a)
        {
            Node n = new Node(a);
            if (start == null) { start = n; return; }
            Node lastNode = start;
            while ((lastNode!=null)&&(lastNode.next != null)) lastNode = lastNode.next;
            lastNode.next = n;
        }
        public void printList()
        {
            Node temp=start;
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public Node NthElementFromEnd(int n)
        {
            Node temp = start;
            int counter = 0;
            while ((temp != null) && (counter++ < n))
            {
                temp = temp.next;
            }
            Node index1 = start;
            while(temp!=null)
            {
                temp = temp.next;
                index1 = index1.next;
            }
            return index1;
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int a)
        {
            this.data = a;
            next = null;
        }
    }
}
