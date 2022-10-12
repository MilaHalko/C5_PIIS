namespace Pacman.Algos;
using Pacman.Classes;

public class MiniMax : IAlgorithm
{
    public MiniMax()
    {
    }

    public int Apply(State state, int depth, bool maxPlayer)
    {
        if (depth == 0 || state.EnemyWon())
        {
            return state.GetScore();
        }

        int bestScore = maxPlayer? Int32.MinValue : Int32.MaxValue;
        foreach (var adjacent in state.GetAdjacents()) 
        {
            int score = Apply(adjacent, depth - 1, !maxPlayer);
            bestScore = maxPlayer? Math.Max(bestScore, score) : Math.Min(bestScore, score);
        }
        return bestScore;
    }
}