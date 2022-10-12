using Pacman.Classes;
namespace Pacman.Algos;

public interface IAlgorithm
{ 
    int Apply(State position, int depth, bool maxPlayer);
}