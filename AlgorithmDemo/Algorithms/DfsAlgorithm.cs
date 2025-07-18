using AlgorithmDemo.Data;

namespace AlgorithmDemo.Algorithms;

public class DfsAlgorithm : IAlgorithm
{
    private readonly Tree _tree = new BinaryTreeBuilder(16).Build();

    public void Execute()
    {
        Dfs(_tree, 0);
    }

    private static void Dfs(Tree? node, int level)
    {
        if (node == null) return;

        Console.WriteLine(node.Value);

        Dfs(node.LeftLeaf, level + 1);
        Dfs(node.RightLeaf, level + 1);
    }
}