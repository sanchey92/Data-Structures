using System;
using System.Collections.Generic;
using System.Net;

namespace Graph
{
    public class Graph
    {
        private List<Vertex> _vertexes = new List<Vertex>();
        private List<Edge> _edges = new List<Edge>();

        public int VertexCount => _vertexes.Count;
        public int EdgeCount => _edges.Count;

        public void AddVertex(Vertex vertex) => _vertexes.Add(vertex);

        public void AddEdge(Vertex from, Vertex to) => _edges.Add(new Edge(from, to));

        public int[,] GetMatrix()
        {
            var matrix = new int[_vertexes.Count, _vertexes.Count];

            foreach (var edge in _edges)
            {
                var row = edge.From.Number - 1;
                var column = edge.To.Number - 1;

                matrix[row, column] = edge.Weight;
            }

            return matrix;
        }

        public List<Vertex> GetVertex(Vertex vertex)
        {
            var result = new List<Vertex>();

            foreach (var edge in _edges)
            {
                if (edge.From == vertex) result.Add(edge.To);
            }

            return result;
        }

        public bool Wave(Vertex start, Vertex finish)
        {
            var list = new List<Vertex>();

            list.Add(start);

            for (var i = 0; i < list.Count; i++)
            {
                var vertex = list[i];
                foreach (var v in GetVertex(vertex))
                {
                    if (!list.Contains(v)) list.Add(v);
                }
            }

            return list.Contains(finish);
        }
    }
}