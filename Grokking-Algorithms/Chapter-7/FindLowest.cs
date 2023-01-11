using System.Collections.Generic;

namespace Chapter_7;

public static class FindLowest
{
    private const double _infinity = double.PositiveInfinity;
    private static readonly Dictionary<string, Dictionary<string, double>> _graph = new();
    private static readonly List<string> _processed = new();

    public static string Find()
    {
        _graph.Add("start", new Dictionary<string, double>());
        _graph["start"].Add("a", 6.0);
        _graph["start"].Add("b", 2.0);

        _graph.Add("a", new Dictionary<string, double>());
        _graph["a"].Add("fin", 1.0);

        _graph.Add("b", new Dictionary<string, double>());
        _graph["b"].Add("a", 3.0);
        _graph["b"].Add("fin", 5.0);

        _graph.Add("fin", new Dictionary<string, double>());

        var costs = new Dictionary<string, double>
        {
            { "a", 6.0 },
            { "b", 2.0 },
            { "fin", _infinity }
        };

        var parents = new Dictionary<string, string>
        {
            { "a", "start" },
            { "b", "start" },
            { "fin", null }
        };

        var node = FindLowestCostNode(costs);
        while (node != null)
        {
            var cost = costs[node];
            var neighbors = _graph[node];
            foreach (var n in neighbors.Keys)
            {
                var new_cost = cost + neighbors[n];
                if (costs[n] > new_cost)
                {
                    costs[n] = new_cost;
                    parents[n] = node;
                }
            }
            _processed.Add(node);
            node = FindLowestCostNode(costs);
        }
        return string.Join(", ", costs);
    }

    private static string FindLowestCostNode(Dictionary<string, double> costs)
    {
        var lowestCost = double.PositiveInfinity;
        string lowestCostNode = null;
        foreach (var node in costs)
        {
            var cost = node.Value;
            if (cost < lowestCost && !_processed.Contains(node.Key))
            {
                lowestCost = cost;
                lowestCostNode = node.Key;
            }
        }
        return lowestCostNode;
    }
}
