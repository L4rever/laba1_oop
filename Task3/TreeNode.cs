using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TreeNode
    {
        public string Value { get; set; }
        public List<TreeNode> Children { get; set; }

        public TreeNode(string value)
        {
            Value = value;
            Children = new List<TreeNode>();
        }

        public void AddChild(TreeNode child)
        {
            Children.Add(child);
        }

        public void PrintAllValues(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent * 2) + Value);

            if (Children.Count == 0)
                return;

            foreach (var child in Children)
            {
                child.PrintAllValues(indent + 1);
            }
        }
    }
}
