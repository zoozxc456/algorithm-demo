namespace AlgorithmDemo.Algorithms;

public class BacktrackingAlgorithm : IAlgorithm
{
    private readonly List<string> _data = [];

    public BacktrackingAlgorithm()
    {
        for (var index = 'A'; index <= 'D'; index++)
        {
            _data.Add(index.ToString());
        }
    }

    public void Execute()
    {
        Backtrack(_data, 0);
    }

    private static void Backtrack(List<string> list, int currentIndex)
    {
        if (currentIndex == list.Count)
        {
            Console.WriteLine(string.Join("", list));
            return;
        }

        for (var index = currentIndex; index < list.Count; index++)
        {
            Swap(list, currentIndex, index);
            Backtrack(list, currentIndex + 1);
            Swap(list, currentIndex, index);
        }
    }

    private static void Swap(List<string> list, int i, int j) => (list[i], list[j]) = (list[j], list[i]);
}