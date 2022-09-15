using System;

namespace Lab1
{

    class Graph
    {
        private List<int> nodes;

        public List<int> Nodes
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

        public static void Ribs(int[,] matrix, ref List<int> v1, ref List<int> v2)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = i; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        v1.Add(i);
                        v2.Add(j);
                    }
                }
            }
        }
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
            int matrixSize;

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
            }

/*            List<int> a = new List<int>();*/
            /*a.Add(int.Parse(Console.ReadLine()));*/

/*            Graph graph = new Graph();*/
            /*graph.Nodes2 = a;
            Console.WriteLine(graph.Nodes2[0]);
            a.Clear();
            Console.WriteLine(a[0]);*/
/*
            for(int i = 0; i < 5; i++)
            {
               a.Add(int.Parse(Console.ReadLine()));
            }

            graph.AddValue(a);
            foreach(int i in graph.Nodes)
            {
                Console.WriteLine(i);
            }*/

            List<int> v1 = new List<int>();
            List<int> v2 = new List<int>();

            Ribs(matrix, ref v1, ref v2);

            Console.WriteLine("Точки: ");
            for( int i = 0; i < v1.Count; i++)
            {
                Console.WriteLine($"{v1[i]}  {v2[i]} \n");
            }

            int[,] indicency = new int[matrixSize, v1.Count];

            for (int i = 0; i < matrixSize; i++)
            {
                indicency[v1[i], i] = 1;
                indicency[v2[i], i] = 1;
            }

            Print(indicency, matrixSize);

            /*graph.AddValue(int.Parse(Console.ReadLine()));*/
            /*Console.WriteLine(graph.Nodes2[0]);*/

            /*graph.Nodes = 5;
            Console.WriteLine(graph.Nodes2[0]);*/


        }
    }
}