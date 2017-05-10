using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10
{
    public static class A_DFS
    {
        private static int counter = 1;

        public static void DFS(int node, int[,] graph, int n, int[] preVisit, int[] postVisit, int[] color,
            int[,] edgeType)
        {

            if (color[node] == -1)
            {
                return;
            }
            color[node] = 1;
            preVisit[node] = counter++;
            Console.Write((char)(node + 65) + ", ");
            for (int i = 0; i < n; i++)
            {
                if (color[i] == 1 && i != node)
                {
                    edgeType[node,i] = -1;
                }
                if (graph[node,i] == 1 && color[i] == 0)
                {
                    edgeType[node,i] = 1;
                    DFS(i, graph, n, preVisit, postVisit, color, edgeType);
                }
                color[node] = -1;
            }
            postVisit[node] = counter++;
        }

        public static int[][] readData(StreamReader stream)
        {
            string line;
            int[][] graph = null;

            while ((line = stream.ReadLine()) != null)
            {
                System.Console.WriteLine(line);

            }
            return graph;
        }
        public static void print(int[] preVisit, int[] postVisit, int[,] edgeType)
        {
            Console.WriteLine();
            for (int i = 0; i < preVisit.Length; i++)
            {
                Console.Write(preVisit[i] + ", ");
            }
            Console.WriteLine();
            for (int i = 0; i < postVisit.Length; i++)
            {
                Console.Write(postVisit[i] + ", ");
            }
            Console.WriteLine();
            for (int i = 0; i < edgeType.Length; i++)
            {
                for (int j = 0; j < edgeType.Length; j++)
                {
                    if (edgeType[i,j] == 1)
                    {
                        Console.WriteLine("[" + i + ", " + j + "] - древесное");
                    }
                    if (edgeType[i,j] == -1)
                    {
                        Console.WriteLine("[" + i + ", " + j + "] - обратное");
                    }
                }

            }
        }
    }
}
