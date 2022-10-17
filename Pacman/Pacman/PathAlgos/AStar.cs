using Pacman.Classes;
namespace Pacman.PathAlgos;

public class AStar : IPathSearch
{
    private  PriorityQueue<State, int> _openNodes = new List<Cell>();
    private List<State> _closedNodes = new List<Cell>();
    
    public int FindPath(State state)
    {
        _openNodes.Add(state, GetF());
        _openNodes.Add(state.GetAdjacents());

        while (_openNodes.Count != 0)
        {
            
        }
        return 1;
    }
    
    private Cell[] ReconstructPath()
    {
        
    }
}

class PathNode
{
    public PathNode parent { get; }
    public Cell cell { get; }
    public int g { get; }
    public int h { get; }

    public PathNode(Cell cell, PathNode parent, int distance, int heuristic = 1)
    {
        this.cell = cell;
        this.parent = parent;
        g = distance;
        h = heuristic;
    }
    public int GetF()
    {
        return g + h;
    }
}