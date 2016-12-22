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
                else 
                {
                    head.Right = newElement;
                }
            }
        }

        /// <summary>
        /// create a new tre without element which we want delete
        /// </summary>
        /// <param name="currentElement"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private TreeElement RemoveElement(TreeElement currentElement, T value)
        {
            if (currentElement == null)
            {
                return null;
            }

            if (value.CompareTo(currentElement.Value) < 0)
            {
                currentElement.Left = RemoveElement(currentElement.Left, value);
               
            }
            else if (value.CompareTo(currentElement.Value) > 0)
            {
                currentElement.Right = RemoveElement(currentElement.Right, value);
            }
            else
            {
                if (currentElement.Left == null && currentElement.Right == null)
                {
                    return null;
                }
                if (currentElement.Left == null && currentElement.Right != null)
                {
                    currentElement = currentElement.Right;
                }
                else if (currentElement.Left != null && currentElement.Right == null)
                {
                    currentElement = currentElement.Left;
                }
                else
                {                  
                    var curLeft = currentElement.Left;
                    var curRight = currentElement.Right;
                    currentElement = currentElement.Left;
                    while (curLeft.Right != null)
                    {
                        curLeft = curLeft.Right;
                    }
                    curLeft.Right = curRight;
                }
            }
            return currentElement;
        }

        /// <summary>
        /// remove element from list
        /// </summary>
        /// <param name="value"></param>
        public void Remove(T value)
        {
            head = RemoveElement(head, value);
        }

        /// <summary>
        /// search element in tree
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool SearchElement(T value)
        {
            var temp = head;
            while (temp != null)
            {
                if (value.CompareTo(temp.Value) == 0)
                {
                    return true;
                }
                if (value.CompareTo(temp.Value) > 0)
                {
                    temp = temp.Right;
                }
                else
                {
                    temp = temp.Left;
                }
            }
            return false;
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
