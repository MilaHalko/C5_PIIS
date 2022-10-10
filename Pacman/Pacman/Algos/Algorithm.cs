using Pacman.Classes;
namespace Pacman.Algos;

public class Algorithm
{
    protected Field _field;

    protected Algorithm(Field f)
    {
        _field = f;
    }
    int Apply(Cell position, int depth, bool maxPlayer);
}