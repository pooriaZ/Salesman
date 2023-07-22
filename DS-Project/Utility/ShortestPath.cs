using System;
using System.Collections.Generic;

public class ShortestPath
{

    private static readonly int NO_PARENT = -1;

    public static int[] dijkstra(int[,] adjacencyMatrix,
        int startVertex)
    {
        int nVertices = adjacencyMatrix.GetLength(0);

        int[] shortestDistances = new int[nVertices];

        bool[] added = new bool[nVertices];

        for (int vertexIndex = 0;
             vertexIndex < nVertices;
             vertexIndex++)
        {
            shortestDistances[vertexIndex] = int.MaxValue;
            added[vertexIndex] = false;
        }

        shortestDistances[startVertex] = 0;

        int[] parents = new int[nVertices];

        parents[startVertex] = NO_PARENT;

        for (int i = 1; i < nVertices; i++)
        {
            int nearestVertex = -1;
            int shortestDistance = int.MaxValue;
            for (int vertexIndex = 0;
                 vertexIndex < nVertices;
                 vertexIndex++)
            {
                if (!added[vertexIndex] &&
                    shortestDistances[vertexIndex] <
                    shortestDistance)
                {
                    nearestVertex = vertexIndex;
                    shortestDistance = shortestDistances[vertexIndex];
                }
            }
        

        added[nearestVertex] = true;

        for (int vertexIndex = 0;
             vertexIndex < nVertices;
             vertexIndex++)
            {
                int edgeDistance = adjacencyMatrix[nearestVertex, vertexIndex];

                if (edgeDistance > 0
                    && ((shortestDistance + edgeDistance) <
                        shortestDistances[vertexIndex]))
                {
                    parents[vertexIndex] = nearestVertex;
                    shortestDistances[vertexIndex] = shortestDistance +
                                                     edgeDistance;
                }
            }
        }
        return parents;
    }

    public static List<int> ShortestPathTwoNodes(int sourceId, int destinationId, int[] sp)
    {
        List<int> path = new List<int>();

        var dstId = destinationId;
        var srcId = sourceId;

        path.Add(dstId);

        int node = 0;
        node = sp[dstId - 1];
        path.Add(node + 1);
        while (node != -1)
        {
            node = sp[node];
            path.Add(node + 1);
        }
        path.Reverse();
        path.Remove(0);

        return path;
    }
}