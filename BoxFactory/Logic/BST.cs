using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Logic
{
    public class BST<Key, Val> where Key : IComparable<Key>
    {
        private Node<Key, Val> _root;
        public BST()
        {
            _root = null;
        }
        public void Insert(Key key, Val val)
        {
            if (_root == null)
            {
                _root = new Node<Key, Val>(key, val);
            }
            else
            {
                InsertRecursively(_root, key, val);
            }
        }
        public void InsertRecursively(Node<Key, Val> root, Key key, Val val)
        {
            if (key.CompareTo(root.KeyData) < 0)
            {
                if (root.Left == null)
                {
                    root.Left = new Node<Key, Val>(key, val);
                }
                else
                {
                    InsertRecursively(root.Left, key, val);
                }
            }
            else
            {
                if (root.Right == null)
                {
                    root.Right = new Node<Key, Val>(key, val);
                }
                else
                {
                    InsertRecursively(root.Right, key, val);
                }
            }
        }
        public bool Delete(Key key)
        {
            return RemoveRecursively(_root, _root, key);
        }
        private bool RemoveRecursively(Node<Key, Val> current, Node<Key, Val> previous, Key key)
        {
            if (current == null) return false;
            if (key.CompareTo(current.KeyData) < 0)
            {
                return RemoveRecursively(current.Left, current, key);

            }
            else if (key.CompareTo(current.KeyData) > 0)
            {
                return RemoveRecursively(current.Right, current, key);
            }

            else
            {
                if (current.Left == null && current.Right == null)// No children // leaves
                {
                    if (previous.Right == current) previous.Right = null;
                    if (previous.Left == current) previous.Left = null;
                    return true;
                }
                else if (current.Left == null)
                {

                    if (previous.Right == current) previous.Right = current.Right;
                    if (previous.Left == current) previous.Left = current.Right;
                    return true;

                }
                else if (current.Right == null)
                {
                    if (previous.Right == current) previous.Right = current.Left;
                    if (previous.Left == current) previous.Left = current.Left;
                    return true;
                }
                else
                {
                    var minValNode = GetMinValue(current.Right);
                    if (previous.Right == current) previous.Right = minValNode;
                    if (previous.Left == current) previous.Left = minValNode;
                    return true;
                }

            }
        }
        public Node<Key, Val> GetMinValue(Node<Key, Val> node) //while delete we want to replace the node deleted with smallest node that higher key val 
        {
            var current = node;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }
        public bool Contains(Key key) // check if the given key exist 
        {
            var node = Search(key);
            if (node == null) return false;
            return true;
        }
        public Val Search(Key key) //method public for search
        {
            if (_root == null)
            {
                return default;
            }
            else
            {
                Node<Key, Val> node = RecursivelyGetNode(key, _root);
                return node == null ? default : node.ValData;
            }
        }
        private Node<Key, Val> RecursivelyGetNode(Key key, Node<Key, Val> current)
        {
            if (current == null) return null;

            if (key.CompareTo(current.KeyData) == 0)
            {
                return current;
            }
            if (key.CompareTo(current.KeyData) < 0)
            {
                if (current.Left != null)
                {
                    return RecursivelyGetNode(key, current.Left); // Recursively search in the left subtree
                }
            }
            if (key.CompareTo(current.KeyData) > 0)
            {
                if (current.Right != null)
                {
                    return RecursivelyGetNode(key, current.Right); // Recursively search in the right subtree
                }
            }
            return null; // Key not found in the subtree, return null
        }
        private void ScanInOrder(Node<Key, Val> node, Action<Val> action)
        {
            if (node == null) return;
            ScanInOrder(node.Left, action);
            action(node.ValData);
            ScanInOrder(node.Right, action);
        }
        public void ScanInOrder(Action<Val> action) => ScanInOrder(_root, action);
        public bool ContainsApToTenPresent(Key key) // check if the key exists
        {
            var node = SearchApToTenPresent(key);
            if (node == null) return false;
            return true;
        }
        public Val SearchApToTenPresent(Key key) // responsible to find the node 
        {
            if (_root == null)
            {
                return default;
            }
            else
            {
                Node<Key, Val> node = RecursivelyGetNodeTen(key, _root);
                return node == null ? default : node.ValData;
            }
        }
        private Node<Key, Val> RecursivelyGetNodeTen(Key key, Node<Key, Val> current) // recursively searches for the specific node 
        {
            if (key is double userChoice)
            {
                if (current.KeyData is double tempSize)
                {                  
                    double result = userChoice+(userChoice*0.1);
                    if (current == null) return null;
                    if(tempSize <= result && tempSize >= userChoice)
                    {                
                        return current;              
                    }             
                    if (key.CompareTo(current.KeyData) < 0 )
                    {
                        if (current.Left != null)
                        {
                            return RecursivelyGetNodeTen(key, current.Left); // Recursively search in the left subtree
                        }
                    }
                    if (key.CompareTo(current.KeyData) > 0 )
                    {
                        if (current.Right != null )
                        {
                            return RecursivelyGetNodeTen(key, current.Right); // Recursively search in the right subtree
                        }
                    }
                    return null; // Key not found in the subtree, return null
                }
                else return null;
            }
            else return null;
        }
    }
}
