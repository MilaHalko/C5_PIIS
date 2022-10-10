using Pacman.Classes;

namespace Pacman.Algos;

public class MiniMax
{
    private Field _field;
    // TODO: What is depth???
    private int _depth = 6;

    public MiniMax(Field f)
    {
        _field = f;
    }

    public int Apply(Cell position, int depth, bool maxPlayer)
    {
        if (depth == 0 || _field.EnemyWon())
        {
            return position.GetScore();
        }

        int bestScore = maxPlayer? Int32.MinValue : Int32.MaxValue;
        foreach (var adjacent in position.GetAdjCells()) 
        {
            int score = Apply(adjacent, depth - 1, !maxPlayer);
            bestScore = maxPlayer? Math.Max(bestScore, score) : Math.Min(bestScore, score);
        }
        return bestScore;
    }
}