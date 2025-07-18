namespace AlgorithmDemo.Data;

public class BinaryTreeBuilder(int itemNum)
{
    private readonly Tree _root = new() { Value = 0 };

    public Tree Build()
    {
        for (var i = 1; i <= itemNum; i++)
        {
            Insert(i);
        }

        return _root;
    }

    void Insert(int value)
    {
        var node = new Tree { Value = value };

        var availableNode = FindAvailableNode(_root);

        if (availableNode.LeftLeaf == null)
        {
            node.ParentNode = availableNode;
            availableNode.LeftLeaf = node;
        }
        else if (availableNode.RightLeaf == null)
        {
            node.ParentNode = availableNode;
            availableNode.RightLeaf = node;
        }
    }

    Tree FindAvailableNode(Tree node)
    {
        var queue = new Queue<Tree>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();

            if (currentNode.LeftLeaf == null || currentNode.RightLeaf == null) return currentNode;

            queue.Enqueue(currentNode.LeftLeaf);
            queue.Enqueue(currentNode.RightLeaf);
        }

        return null;
    }
}

public class Tree
{
    public Tree ParentNode { get; set; }
    public int Value { get; set; }
    public Tree? LeftLeaf { get; set; }
    public Tree? RightLeaf { get; set; }
}