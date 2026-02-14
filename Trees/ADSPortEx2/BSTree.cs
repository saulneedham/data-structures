using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADSPortEx2
{

    class BSTree<T> : BinTree<T> where T : IComparable
    {
        //No new attributes as we have protected from binTree
        public BSTree()
        {
            root = null;
        }
        public void InsertItem(T item)
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

            //Do nothing if data matches as no duplicates are in the tree.
        }

        public int Height()
        {
            return height(root);
        }

        protected int height(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(height(tree.Left), height(tree.Right));
            }
        }

        public int Count()
        {
            return count(root);
        }

        private int count(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + count(tree.Left) + count(tree.Right);
            }
        }

        public void Update(T item)
        {
            update(item, root);
        }

        private void update(T item, Node<T> node)
        {
            if (node == null)
            {
                Console.WriteLine("Movie not found in tree.");
                return;
            }
            else if (item.CompareTo(node.Data) < 0)
            {
                update(item, node.Left);
            }
            else if (item.CompareTo(node.Data) > 0)
            {
                update(item, node.Right);
            }
            else
            {
                node.Data = item;
                Console.WriteLine("Item updated successfully.");
            }
        }

    }
}
