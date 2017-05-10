using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    public  class Dijkstra
    {
        private static int INF = int.MaxValue / 2;

        private int numberVertex;
        private int numberEdge;
        private List<int> graph;
        private List<int> weight;
        private bool[] used;
        private int[] distance;

        private int[] parent;
        int start;

        private void Dejkstra(int s)
        {
            distance[s] = 0;
            for (int iter = 0; iter < numberVertex; ++iter)
            {
                int v = -1;
                int distV = INF;

                for (int i = 0; i < numberVertex; ++i)
                {
                    if (used[i])
                    {
                        continue;
                    }
                    if (distV < distance[i])
                    {
                        continue;
                    }
                    v = i;
                    distV = distance[i];
                }

                for (int i = 0; i < graph[v]; ++i)
                {
                    int u = graph[v];
                    int weightU = weight[v];
                    
                    if (distance[v] + weightU < distance[u])
                    {
                        distance[u] = distance[v] + weightU;
                        parent[u] = v;
                    }
                }
                used[v] = true;
            }
        }

        private void printWay(int v)
        {
            if (v == -1)
            {
                return;
            }
            printWay(parent[v]);
            Console.Write((v + 1) + " ");
        }


        private void PrintData()
        {
  	        for (int v = 0; v<numberVertex; ++v)
            {
  	            if (distance[v] != INF) {
  		            Console.Write(distance[v] + " ");
                } else {
  		            Console.Write("-1 ");
                }
  	        }
  	        for(int i = 0; i<parent.Length;i++){
  	            Console.WriteLine(parent[i]);
  	        }
            Console.WriteLine();
  	        for (int v = 0; v<numberVertex; ++v) {
  	            Console.Write((v + 1) + ": ");
  	            if (distance[v] != INF) {

                    printWay(v);
  	            }
                Console.WriteLine();
  	        }
      }
    }
}
