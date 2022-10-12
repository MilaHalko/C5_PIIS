using Pacman.Classes;
namespace Pacman.PathAlgos;

public class AStar : IPathSearch
{
    private  List<State> _openNodes = new List<Cell>();
    private List<State> _closedNodes = new List<Cell>();
    
    
    public int FindPath(State state)
    {
        _openNodes.Add(state);
        _openNodes.Add(state.GetAdjacents());
        
        // TODO return valid please
        return 1;
    }

    private Cell[] ReconstructPath()
    {
        
    }
}