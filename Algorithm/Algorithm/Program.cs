using Struct;

Graph g = new Graph(8);

g.AddEdge(0, 1);
g.AddEdge(0, 2);
g.AddEdge(2, 0);

g.AddEdge(1, 3);
g.AddEdge(1, 4);

g.AddEdge(2, 5);

g.AddEdge(4, 5);
g.AddEdge(4, 6);
g.AddEdge(4, 7);


int key = int.Parse(Console.ReadLine());
Console.Write("Following is Breadth First " +
              "Traversal(starting from " +
             $"vertex {key})\n");
g.BFS(key);

Console.WriteLine(
           "\nFollowing is Depth First Traversal "
           + $"(starting from vertex {key})");

g.DFS(key);
Console.ReadKey();
