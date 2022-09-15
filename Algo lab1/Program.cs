using System;

namespace Lab1
{

    class Graph
    {
        private List<int> nodes;
        public int Nodes
        {
            set { nodes.Add(value); }
        }

        public List<int> Nodes2
        {
            get { return nodes; }
            set
            {
                nodes = value;
            }
        }

        public override string ToString()
        {
            return $"{nodes[0]}";
        }

        public Graph()
        {
            nodes = new List<int>();
        }

        public void AddValue(int a)
        {
            nodes.Add(a);
        }

        public void AddValue(List<int> a)
        {
            foreach (int i in a)
            {
                nodes.Add(i);
            }
        }
    }
    class Program
    {
        public static void Print(int[,] array, int size)
        {
            Console.WriteLine("Ваша матрица: ");
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void Main()
        {
            /*int matrixSize;

            Console.WriteLine("Введите кол-во вершин графа: ");
            matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.WriteLine("Введите число: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }*/

            List<int> a = new List<int>();
            /*a.Add(int.Parse(Console.ReadLine()));*/

            Graph graph = new Graph();
            /*graph.Nodes2 = a;
            Console.WriteLine(graph.Nodes2[0]);
            a.Clear();
            Console.WriteLine(a[0]);*/

            for(int i = 0; i < 5; i++)
            {
               a.Add(int.Parse(Console.ReadLine()));
            }

            graph.AddValue(a);
            foreach(int i in graph.Nodes2)
            {
                Console.WriteLine(i);
            }


            /*graph.AddValue(int.Parse(Console.ReadLine()));*/
            /*Console.WriteLine(graph.Nodes2[0]);*/

            /*graph.Nodes = 5;
            Console.WriteLine(graph.Nodes2[0]);*/

            
        }
    }
}