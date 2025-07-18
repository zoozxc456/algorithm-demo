using AlgorithmDemo.Algorithms;

var algorithms = new List<IAlgorithm>
{
    new DfsAlgorithm(),
    new BfsAlgorithm(),
    new BacktrackingAlgorithm()
};

algorithms.ForEach(x => x.Execute());