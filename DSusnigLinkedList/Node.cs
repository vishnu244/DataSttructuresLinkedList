﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSusnigLinkedList
{
    public class Node
    {
        public int data;
        public Node link;
        public Node(int data)
        {
            this.data = data;
            this.link = null;
        }
    }
}
