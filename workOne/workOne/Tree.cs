using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkOne
{
    /// <summary>
    /// class for binary tree with realization of iterator
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Tree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private class TreeElement
        {
            public T Value { get; set; }
            public TreeElement Right { get; set; }
            public TreeElement Left { get; set; }

            public TreeElement(T value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        private TreeElement head;

        public Tree()
        {
            head = null;
        }

        /// <summary>
        /// add new element in tree
        /// </summary>
        /// <param name="value"></param>
        public void AddValue(T value)
        {
            if (head == null)
            {
                head = new TreeElement(value);
            }
            else
            {
                var newElement = new TreeElement(value);
                var temp = head;
                while (temp != null)
                {
                    if (newElement.Value.CompareTo(temp.Value) > 0)
                    {
                        if (temp.Right == null)
                        {
                            temp.Right = newElement;
                            return;
                        }
                        temp = temp.Right;
                    }
                    else
                    {
                        if (temp.Left == null)
                        {
                            temp.Left = newElement;
                            return;
                        }
                        temp = temp.Left;
                    }
                }

                if (newElement.Value.CompareTo(head.Value) <= 0)
                {
                    head.Left = newElement;
                }
                else head.Right = newElement;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new TreeEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// class for tree iterator
        /// </summary>
        private class TreeEnumerator : IEnumerator<T>
        {
            private Tree<T> tree;
            private List<T> treeList;
            private int position;

            public TreeEnumerator(Tree<T> tree)
            {
                this.tree = tree;
                treeList = new List<T>();
                position = -1;
                MakeTreeList(tree.head);
            }

            /// <summary>
            /// create list with elements of tree
            /// </summary>
            /// <param name="element"></param>
            private void MakeTreeList(TreeElement element)
            {
                if (element != null)
                {
                    if (element.Right != null)
                    {
                        MakeTreeList(element.Right);
                    }
                    if (element.Left != null)
                    {
                        MakeTreeList(element.Left);
                    }
                    treeList.Add(element.Value);
                }
            }

            public object Current
            {
                get
                {
                    return Current;
                }
            }

            T IEnumerator<T>.Current
            {
                get
                {
                    return treeList[position];
                }
            }

            public void Dispose()
            {
            }

            /// <summary>
            /// move to next element
            /// </summary>
            /// <returns></returns>
            public bool MoveNext()
            {
                if (position < treeList.Count - 1)
                {
                    ++position;
                    return true;
                }
                return false;
            }

            /// <summary>
            /// reset enumerator
            /// </summary>
            public void Reset()
            {
                position = -1;
            }
        }
    }
}
