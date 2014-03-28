using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SampleQuestions
{
   public class MyTree
    {
        Stack myStack = new Stack();
        TreeNode root;

        public void insert(int data)
        {
            if(root==null)
            {
                root = new TreeNode(data);
                return;
            }
            TreeNode temp = root;
            while (temp != null)
            {
                if (temp.data > data) 
                {
                    if(temp.left==null)
                    {
                        temp.left = new TreeNode(data);
                        return;
                    }
                    temp = temp.left; 
                }
                else {
                    if(temp.right==null)
                    {
                        temp.right = new TreeNode(data);
                        return;
                    }
                    temp = temp.right;
                }
            }

        }
        public void print()
        {
            TreeNode temp = root;
            //Go to Left as you can
            myStack.Push(temp);
            temp = (TreeNode)myStack.Pop();

            while (temp != null) { myStack.Push(temp); temp = temp.left; }
            while (myStack.Count > 0)
            {
                temp = (TreeNode)myStack.Pop();
                Console.WriteLine(temp.data);
                if (temp.right != null)
                {
                    temp = temp.right;
                    while (temp != null) { myStack.Push(temp); temp = temp.left; }
                }
            }
        }
        private void printR(TreeNode n)
        {
            if (n == null) return;
            printR(n.left);
            Console.WriteLine(n.data);
            printR(n.right);
        }
        public int calculateSum(int label)
        {
            int sum = 0;
            int index = 0;
            TreeNode n = root;
            calculateSum(n, index, label, ref sum);
            return sum;
        }
        private void calculateSum(TreeNode n,int index,int label,ref int sum)
        {
            if (n == null) return;
            if (index == label)
                sum = sum + n.data;
            calculateSum(n.left, index + 1, label, ref sum);
            calculateSum(n.right, index + 1, label, ref sum);
        }
        public void printR()
        {
            TreeNode temp = root;
            printR(temp);
        }
        public TreeNode getDoublyLinkList()
        {
            TreeNode temp = root;
            TreeNode lastPrinted=null;
            getDoublyLinkList(temp,ref lastPrinted);
            return lastPrinted;

        }
        private void getDoublyLinkList(TreeNode n,ref TreeNode lastPrinted)
        {
            if (n == null) return;
            getDoublyLinkList(n.left,ref lastPrinted);
            if (n != null) {n.left = lastPrinted; }
            if (lastPrinted != null) { lastPrinted.right = n; }
            lastPrinted = n;
            getDoublyLinkList(n.right,ref lastPrinted);
        }
        public bool checkIfTreeIsBinary(TreeNode treeRoot)
        {
            TreeNode temp = treeRoot;
            if (temp.right != null)
            {
                if (temp.data > temp.right.data) return false;
            }
            if (temp.left != null)
            {
                if (temp.data < temp.left.data) return false;
            }
            bool b1 = checkIfBinary(temp.left, findLowestOnBranch(temp
                
                ), true);
            bool b2 = checkIfBinary(temp.right, findHighestOnBranch(temp), false);
            return b1 && b2; ;
            
        }
        private int findLowestOnBranch(TreeNode T)
        {
            if (T.left == null) return T.data;
            return findLowestOnBranch(T.left);
        }
        private int findHighestOnBranch(TreeNode T)
        {
            if (T.right == null) return T.data;
            return findHighestOnBranch(T.right);
        }
        private bool checkIfBinary(TreeNode node,int compareValue, bool AmILeft)
        {
            if (node == null) return true;
            if (AmILeft)
            {
                if (node.right != null)
                {
                    if (node.right.data > compareValue) { return false; }
                }
            }
            else
            {
                if(node.left!=null)
                {
                    if (node.left.data < compareValue) { return false; }
                }
            }
            if (node.right != null)
            {
                if (node.data > node.right.data) return false;
            }
            if (node.left != null)
            {
                if (node.data < node.left.data) return false;
            }
            return (checkIfBinary(node.left,findLowestOnBranch(node),true))&&checkIfBinary(node.right,findHighestOnBranch(node),true);
        }
    }
    public class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int data)
        {
            this.data = data;
        }
    }
}
