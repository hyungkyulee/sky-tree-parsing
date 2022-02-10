using System.Collections.Generic;
using System.Linq;
using TreeParsing.Models.Data;

namespace TreeParsing.Models.Domains
{
    public class Tree
    {
        private Node Root { get; set; }
        
        public Tree(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                Add(number);
            }
        }

        private void Add(int number)
        {
            if (Root == null)
            {
                Root = new Node(number);
                return;
            }

            if (number <= Root.Data)
            {
                Root.LeftLeaf = Add(Root.LeftLeaf, number);
                return;
            }
            
            Root.RightLeaf = Add(Root.RightLeaf, number);
        }
        
        private static Node Add(Node node, int value)
        {
            if (node == null)
            {
                return new Node(value);
            }

            if (value <= node.Data)
            {
                var leftChildNode = Add(node.LeftLeaf, value);
                node.LeftLeaf = leftChildNode;
                return node;
            }

            var rightChildNode = Add(node.RightLeaf, value);
            node.RightLeaf = rightChildNode;

            return node;
        }

        public IEnumerable<int> Traverse()
        {
            if (Root == null) return new List<int>();

            var postOrderedNumbers = new List<int>();
            if (Root.LeftLeaf != null)
            {
                postOrderedNumbers.AddRange(Traverse(Root.LeftLeaf));
            }

            if (Root.RightLeaf != null)
            {
                postOrderedNumbers.AddRange(Traverse(Root.RightLeaf));
            }
            
            postOrderedNumbers.Add(Root.Data);
            return postOrderedNumbers;
        }

        private static IEnumerable<int> Traverse(Node node)
        {
            if (node == null) return new List<int>();
            
            var orderedNumber = new List<int>();
            if (node.LeftLeaf != null)
            {
                orderedNumber.AddRange(Traverse(node.LeftLeaf));
            }

            if (node.RightLeaf != null)
            {
                orderedNumber.AddRange(Traverse(node.RightLeaf));
            }
                
            orderedNumber.Add(node.Data);

            return orderedNumber;
        }
    }
}