namespace Pacman.Classes;

public class PacmanGame
{
    private Field _field = Field.GetDefaultField();

    public void Start()
    {
        _field.PrintField();
        
    }
    public PacmanGame() {}
}