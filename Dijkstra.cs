using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStation
{
    class Dijkstra
    {
        private static int MinimumDistance(int[] distance, bool[] shortestPathTreeSet, int verticesCount)
        {
            int min = int.MaxValue;
            int minIndex = 0;

            for (int v = 0; v < verticesCount; ++v)
            {
                if (shortestPathTreeSet[v] == false && distance[v] <= min)
                {
                    min = distance[v];
                    minIndex = v;
                }
            }

            return minIndex;
        }

        private static void Print(int[] distance, int verticesCount)
        {
            Console.WriteLine("Vertex    Distance from source");

            for (int i = 0; i < verticesCount; ++i)
                Console.WriteLine("{0}\t  {1}", i, distance[i]);
        }

        public static int[] DijkstraAlgo(LinkedList<int[]> graph, int source, int verticesCount)
        {
            int[] distance = new int[verticesCount];
            bool[] shortestPathTreeSet = new bool[verticesCount];
            //setting up distances to be infinte and set all vertex visited to false..
            for (int i = 0; i < verticesCount; ++i)
            {
                distance[i] = int.MaxValue;
                shortestPathTreeSet[i] = false;
            }

            distance[source] = 0;
            int[] myarr = null;
            for (int count = 0; count < verticesCount - 1; ++count)
            {
                int u = MinimumDistance(distance, shortestPathTreeSet, verticesCount);
                shortestPathTreeSet[u] = true;
                int countt = 0;

                foreach (int[] ld in graph)
                {
                    if ((verticesCount - 1) - u == countt)
                    {
                        myarr = ld;
                    }
                    countt++;
                }

                for (int v = 0; v < verticesCount; ++v)
                    // int val = myarr[v];
                   if (!shortestPathTreeSet[v] && Convert.ToBoolean(myarr[v]) && distance[u] != int.MaxValue && distance[u] + myarr[v] < distance[v])
                        distance[v] = distance[u] + myarr[v];
            }

            return distance;

        }

    }
}
