using Pacman.Classes;

namespace Pacman.PathAlgos;

public interface IPathSearch
{
    public int FindPath(Field field, Cell start, Cell finish);
}