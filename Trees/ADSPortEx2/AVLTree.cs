using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{

    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public AVLTree()
        {
            root = null;
        }
        public Node<T> Root
        {
            get { return root; }
        }

        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
            //Inserting in the normal way

            int balance = GetBalanceFactor(root);


            if (balance < -1) //right side too heavy
            {
                Node<T> newRoot = root.Right;
                if (item.CompareTo(newRoot.Data) > 0)
                {
                    Console.WriteLine("Right Right");
                }
                else
                {
                    Console.WriteLine("Right Left");
                }
            }
            else if (balance > 1) //left side too heavy
            {
                Node<T> newRoot = root.Left;
                if (item.CompareTo(newRoot.Data) < 0)
                {
                    Console.WriteLine("Left left");
                }
                else
                {
                    Console.WriteLine("Left Right");
                }
            }
        }

        public int GetBalanceFactor(Node<T> node)
        {
            return height(node.Left) - height(node.Right);
        }

        public new void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        private void removeItem(T item, ref Node<T> tree)
        {
            //Removing data before restructuring
            if (tree == null)
            {
                return;
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
            else
            {
                // Node to be removed is found
                if (tree.Left == null && tree.Right == null) //no children nodes
                {
                    tree = null;
                }
                else if (tree.Left == null) // left child null so move right up
                {
                    tree = tree.Right;
                }
                else if (tree.Right == null) // right child null so move left up
                {
                    tree = tree.Left;
                }
            }
        }


    }
}
