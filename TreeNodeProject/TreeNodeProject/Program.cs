using System;
using System.Collections.Generic;

namespace TreeNodeProject
{
    class Program
    {

        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(1)
            {
                leftChild = new TreeNode(2),
                rightChild = new TreeNode(3)
            };
            tree.leftChild.leftChild = new TreeNode(4);
            tree.leftChild.rightChild = new TreeNode(5)
            {
                leftChild = new TreeNode(8),
                rightChild = new TreeNode(9)
            };
            tree.rightChild.leftChild = new TreeNode(6);
            tree.rightChild.rightChild = new TreeNode(7);

            //tree.rightChild.rightChild.leftChild = tree;

            /*
            Console.Write(tree.Sum(tree));
            Console.Write("\n");


            foreach (int n in tree.FindLevelsTuple(5))
            {
                Console.Write("\n{0}", n);

            }
            foreach (int n in tree.FindLevelsWithClass(5))
            {
                Console.Write("\n{0}", n);

            }
            foreach (int n in tree.FindLevelsStackTuple(5))
            {
                Console.Write("\n{0}", n);

            }
            Console.Write("\n");
            tree.PrintPreOrder(tree);
            Console.Write("\n\n\n");
            tree.PrintInorderTraversal(tree);
            Console.Write("\n\n\n");
            tree.PrintPostOrder(tree);
            */
            Console.Write("\n\n\n");

            Console.Write(tree.RecurceCheck(tree));
            Console.Write("\n\n\n");

        }
    }
    class TreeNode
    {
        private int node;
        public TreeNode leftChild;
        public TreeNode rightChild;
        private bool check;
        public TreeNode(int n)
        {
            this.node = n;
            this.check = false;

        }

        public void PrintPreOrder(TreeNode current)
        {
            if (current == null)
            {
                return;
            }
            Console.Write(current.node);
            PrintPreOrder(current.leftChild);
            PrintPreOrder(current.rightChild);
        }
        public void PrintInorderTraversal(TreeNode current)
        {
            if (current == null)
            {
                return;
            }
            PrintInorderTraversal(current.leftChild);
            Console.Write(current.node);
            PrintInorderTraversal(current.rightChild);
        }
        public void PrintPostOrder(TreeNode current)
        {
            if (current == null)
            {
                return;
            }
            PrintPostOrder(current.leftChild);
            PrintPostOrder(current.rightChild);
            Console.Write(current.node);
        }

        public bool RecurceCheck(TreeNode current)
        {
            if (current == null)
            {
                return true;
            }

            bool leftIsValid = RecurceCheck(current.leftChild);
            if (!leftIsValid)
            {
                return false;
            }

            bool rightIsValid = RecurceCheck(current.rightChild);
            if (!rightIsValid)
            {
                return false;
            }

            if (current.check)
            {
                return false;
            }
            else
            {
                current.check = true;
                return true;
            }
        }
        public int Sum(TreeNode parent)
        {
            int sum = 0;
            if (parent.leftChild != null) sum += Sum(parent.leftChild);
            if (parent.rightChild != null) sum += Sum(parent.rightChild);

            return parent.node + sum;
        }
        public List<int> FindLevels(int n)
        {
            List<int> levels = new List<int>();
            Queue<TreeNode> myQ = new Queue<TreeNode>();
            int level = 0;
            var root = this;
            myQ.Enqueue(root);
            while (myQ.Count != 0)
            {
                root = myQ.Dequeue();
                level++;

                if (root.node == n) levels.Add(level);
                if (root.leftChild != null) myQ.Enqueue(root.leftChild);
                if (root.rightChild != null) myQ.Enqueue(root.rightChild);
            }

            return levels;
        }
        public List<int> FindLevelsWithClass(int n)
        {
            List<int> levels = new List<int>();
            Queue<TreeNodeWithLevel> myQ = new Queue<TreeNodeWithLevel>();
            var root = this;
            int level = 0;
            TreeNodeWithLevel rootWithLevel = new TreeNodeWithLevel(root, level);

            myQ.Enqueue(rootWithLevel);

            while (myQ.Count != 0)
            {
                //Why???   myQ.Dequeue();
                rootWithLevel = myQ.Dequeue();
                root = rootWithLevel.root;
                level = rootWithLevel.level;
                if (root.node == n) levels.Add(level);

                if (root.leftChild != null)
                {
                    rootWithLevel = new TreeNodeWithLevel(root.leftChild, level + 1);

                    myQ.Enqueue(rootWithLevel);
                }
                if (root.rightChild != null)
                {
                    rootWithLevel = new TreeNodeWithLevel(root.rightChild, level + 1);

                    myQ.Enqueue(rootWithLevel);
                }
            }
            return levels;
        }
        public List<int> FindLevelsTuple(int n)
        {
            List<int> levels = new List<int>();
            var root = this;
            int level = 0;
            var t = new Tuple<TreeNode, int>(root, level);
            Queue<Tuple<TreeNode, int>> myQ = new Queue<Tuple<TreeNode, int>>();

            myQ.Enqueue(t);

            while (myQ.Count != 0)
            {
                t = myQ.Dequeue();
                root = t.Item1;
                level = t.Item2;

                if (root.node == n) levels.Add(level);

                if (root.leftChild != null)
                {
                    t = new Tuple<TreeNode, int>(root.leftChild, level + 1);
                    myQ.Enqueue(t);
                }
                if (root.rightChild != null)
                {
                    t = new Tuple<TreeNode, int>(root.rightChild, level + 1);
                    myQ.Enqueue(t);
                }
            }
            return levels;
        }
        public List<int> FindLevelsStackTuple(int n)
        {
            List<int> levels = new List<int>();
            var root = this;
            int level = 0;
            var t = new Tuple<TreeNode, int>(root, level);
            Stack<Tuple<TreeNode, int>> myStack = new Stack<Tuple<TreeNode, int>>();

            myStack.Push(t);

            while (myStack.Count != 0)
            {
                t = myStack.Pop();
                root = t.Item1;
                level = t.Item2;

                if (root.node == n) levels.Add(level);

                if (root.leftChild != null)
                {
                    t = new Tuple<TreeNode, int>(root.leftChild, level + 1);
                    myStack.Push(t);
                }
                if (root.rightChild != null)
                {
                    t = new Tuple<TreeNode, int>(root.rightChild, level + 1);
                    myStack.Push(t);
                }
            }
            return levels;
        }
        public bool TreeValidation(TreeNode current)
        {
            Stack<TreeNode> myStack = new Stack<TreeNode>();
            myStack.Push(current);

            while (myStack.Count != 0)
            {
                current = myStack.Pop();

                if (current.check == true) return false;
                current.check = true;

                if (current.leftChild != null)
                {
                    myStack.Push(current.leftChild);
                }
                if (current.rightChild != null)
                {
                    myStack.Push(current.rightChild);
                }
            }
            return true;
        }
    }
    internal class TreeNodeWithLevel
    {
        internal TreeNode root;
        internal int level;
        public TreeNodeWithLevel(TreeNode m, int n)
        {
            this.root = m;
            this.level = n;
        }
    }
    
}
