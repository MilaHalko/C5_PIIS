using Pacman.Classes;
namespace Pacman.Algos;

public abstract class Algorithm
{
    protected Field _field;

    protected Algorithm(Field f)
    {
        _field = f;
    }

    public abstract int Apply(Cell position, int depth, bool maxPlayer);
}