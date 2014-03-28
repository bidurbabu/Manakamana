using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuestions
{
    public class MyDoublyLinkedList
    {
        DNode start;
        public void insertLast(int data)
        {
            if(start==null)
            {
                start=new DNode(data);
                return;
            }
            DNode tem=start;
            while(tem.next!=null){ tem = tem.next; }
            DNode n=new DNode(tem,data,null);
            tem.next = n;
            return;
        }
        public void insertFirst(int data)
        {
            if (start == null)
            {
                start = new DNode(data);
                return;
            }
            DNode n = new DNode(null, data, start);
            start.previous = n;
            start = n;
            return;
        }
        public void printList()
        {
            DNode temp = start;
            while(temp!=null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void reverse()
        {
            DNode n1 = null;
            DNode n2 = start;
            DNode n3 = start.next;
            while(n2!=null)
            {
                n2.next = n1;
                if(n1!=null)
                {
                    n1.previous = n2;
                }
                n1 = n2;
                n2 = n3;
                if (n3 != null)
                {
                    n3 = n3.next;
                }
                
            }
            start = n1;
        }
    }
    class DNode
    {
        public int data;
        public DNode next;
        public DNode previous;
        public DNode(int v)
        {
            this.data=v;
        }
        public DNode(DNode p,int d,DNode n)
        {
            this.previous = p;
            this.data = d;
            this.next = n;
        }
    }
}
