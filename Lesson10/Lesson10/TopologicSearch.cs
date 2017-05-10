using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public static class TopologicSearch
    {
        static void dfs(List<int> graph, bool[] used, List<int> res, int u)
        {
            used[u] = true;
            foreach (var v in graph[u])
                if (!used[v])
                    dfs(graph, used, res, v);
            res.add(u);
        }

        public static List<int> topologicalSort(List<int>[] graph)
        {
            int n = graph.Length;
            bool[] used = new bool[n];
            List<int> res = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (!used[i])
                {
                    dfs(graph, used, res, i);
                }
            }
            Array.Reverse(res);
            return res;
        }
    }
}
