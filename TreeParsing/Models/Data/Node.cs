namespace TreeParsing.Models.Data
{
    public class Node
    {
        public Node LeftLeaf { get; set; }
        public Node RightLeaf { get; set; }
        public int Data { get; }

        public Node(int data)
        {
            Data = data;
            LeftLeaf = null;
            RightLeaf = null;
        }
    }
}