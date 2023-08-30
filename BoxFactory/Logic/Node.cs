using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Node<Key, Val>  
    {
        public Key KeyData { get; set; } 
        public Val ValData { get; set; }  
        public Node<Key, Val> Right; 
        public Node<Key, Val> Left;  
        public Node(Key key, Val val)
        {
            KeyData = key;
            ValData = val;
        }
    }
}
