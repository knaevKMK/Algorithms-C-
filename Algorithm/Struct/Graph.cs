namespace Struct
{
    public class Graph
    {
        private int V;

        LinkedList<int>[] Adjacency { get; set; }



        public Graph(int v)
        {
            this.Adjacency = new LinkedList<int>[v];

            for (int i = 0; i < Adjacency.Length; i++)
            {
                Adjacency[i] = new LinkedList<int>();
            }

            this.V = v;
        }
        public void AddEdge(int v, int w)
        {
            this.Adjacency[v].AddLast(w);
        }



        private void BSFUtil(LinkedList<int> queue, bool[] visited)
        {
            var s = queue.First();
            Console.Write(s + " ");
            queue.RemoveFirst();

            LinkedList<int> list = this.Adjacency[s];

            foreach (var val in list)
            {
                if (!visited[val])
                {
                    visited[val] = true;
                    queue.AddLast(val);
                }
            }

            if (queue.Any())
            {
                BSFUtil(queue, visited);
            }
        }

        public void BFS(int s)
        {
            bool[] visited = new bool[this.V];
            LinkedList<int> queue = new();

            visited[s] = true;
            queue.AddLast(s);

            BSFUtil(queue, visited);

        }



        void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");

            LinkedList<int> vList = this.Adjacency[v];
            foreach (var n in vList)
            {
                if (!visited[n])
                    DFSUtil(n, visited);
            }
        }

        public void DFS(int v)
        {
            bool[] visited = new bool[V];

            DFSUtil(v, visited);
        }


    }
}