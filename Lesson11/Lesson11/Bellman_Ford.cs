using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public class Bellman_Ford
    {
        private static int INF = int.MaxValue / 2;

        private int numberVertex;
        private int numberEdge;
        private Edge[] edges;
        private bool[]used;
        private int[] distance;

        private int[] parent;
        int start;

        private void dejkstra(int s)
        {
            distance[s] = 0;
            for (int i = 0; i < numberVertex - 1; i++)
            {
                for (int j = 0; j < numberEdge; j++)
                {
                    int from = edges[j].GetFrom();
                    int to = edges[j].GetTo();
                    int weight = edges[j].GetWeight();

                    
                    if (distance[from] == INF)
                    {
                        continue;
                    }

                  
                    distance[to] = Math.Min(distance[to], distance[from] + weight);
                    parent[to] = from;
                }
            }
        }

        private void PrintData()
        {
  	        for (int v = 0; v<numberVertex; ++v) {
  	            if (distance[v] != INF) {
  		            Console.Write(distance[v] + " ");
                } else {
  		            Console.Write("-1 ");
                }
  	        }
        }
    }
}
