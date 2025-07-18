using AlgorithmDemo.Data;

namespace AlgorithmDemo.Algorithms;

public class BfsAlgorithm : IAlgorithm
{
    private readonly Tree _tree = new BinaryTreeBuilder(16).Build();

    public void Execute()
    {
        Bfs(_tree);
    }

    private static void Bfs(Tree node)
    {
        var queue = new Queue<Tree>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var currentNode = queue.Dequeue();
            Display(currentNode);

            if (currentNode.LeftLeaf != null) queue.Enqueue(currentNode.LeftLeaf);
            if (currentNode.RightLeaf != null) queue.Enqueue(currentNode.RightLeaf);
        }
    }

    private static void Display(Tree node) => Console.WriteLine(node.Value);
}