using System;

namespace binaryTree
{
  class Program
  {
    static void Main(string[] args)
    {
      BinaryTree bT = new BinaryTree();
      bT.InsertRec(3);
      bT.InsertRec(4);
      bT.InsertRec(2);
      bT.PrintInOrder();
    }
  }
}
