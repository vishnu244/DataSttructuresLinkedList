using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSusnigLinkedList
{
    public class Node<T>
    {
        public T data;
        public Node<T> link;
        public Node()
        {
          
            this.link = null;
        }
    }
}
