using System;
using System.Collections;
namespace binaryTree
{
  class Node
  {
    public int value;
    public Node left;
    public Node right;
    public Node parent;
    public Node(int x)
    {
      this.value = x;
      this.left = null;
      this.right = null;
      this.parent = null;
    }
  }
}