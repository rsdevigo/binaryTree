using System;
using System.Collections;
namespace binaryTree
{

  class BinaryTree
  {
    public Node root;
    public BinaryTree()
    {
      root = null;
    }

    public void PrintInOrder()
    {
      PrintInOrder(root);
    }

    private void PrintInOrder(Node cur)
    {
      if (cur == null)
      {
        return;
      }

      PrintInOrder(cur.left);
      Console.WriteLine(cur.value);
      PrintInOrder(cur.right);
    }

    public void InsertRec(int value)
    {
      InsertRec(ref this.root, value);
    }

    private void InsertRec(ref Node cur, int value)
    {
      if (null == cur)
      {
        cur = new Node(value);
      }
      else
      {
        if (cur.value > value)
        {
          InsertRec(ref cur.left, value);
          cur.left.parent = cur;
        }
        else
        {
          InsertRec(ref cur.right, value);
          cur.right.parent = cur;
        }
      }
    }
  }
}