using Pacman.Algos;

namespace Pacman.Classes;

public class PacmanGame
{
    private State _state;
    private MiniMax minimax;

    public PacmanGame(Cell pacman, Cell enemy, Cell destination)
    {
        _state = new State(Field.GetDefaultField(), pacman, enemy, destination);
    }

    public void Start()
    {
        _state.FieldOutput();
        
    }
}