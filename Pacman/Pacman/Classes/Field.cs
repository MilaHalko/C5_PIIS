namespace Pacman.Classes;
public class Field
{
    private int[,] _maze;
    private int _height = 5;
    private int _width = 7;
    private int[] _pacman = new int[] { 1, 1 };
    private int[] _enemy = new int[] { 0, 0 };
    private int[] _destPoint = new int[] { 5, 3 };

    private Field(int[,] maze)
    {
        this._maze = maze;
    }

    public static Field GetDefaultField() => new(new[,]
    {
        { 6, 1, 1, 1, 1, 1, 1 },
        { 1, 3, 1, 0, 1, 1, 1 },
        { 0, 0, 1, 0, 1, 0, 0 },
        { 1, 1, 1, 0, 1, 9, 1 },
        { 1, 1, 1, 1, 1, 1, 1 },
    });

    /*
    🟪🟪🟪🟪🟪🟪🟪🟪🟪
    🟪👿▪️▪️▪️▪️▪️▪️🟪
    🟪▪️😇▪️🟪▪️▪️▪️🟪
    🟪🟪🟪▪️🟪▪️🟪🟪🟪
    🟪▪️▪️▪️🟪▪️❌▪️🟪
    🟪▪️▪️▪️▪️▪️▪️▪️🟪
    🟪🟪🟪🟪🟪🟪🟪🟪🟪
     */

    public bool EnemyWon()
    {
        return _pacman[0] == _enemy[0] && _pacman[1] == _enemy[1];
    }
    public void PrintField()
    {
        string[,] stringMaze = new string[_height, _width];
        for (int i = 0; i < _height; i++)
        {
            for (int j = 0; j < _width; j++)
            {
                switch (_maze[i, j])
                {
                    case 0:
                        stringMaze[i, j] = "🟪";
                        break;
                    case 1:
                        stringMaze[i, j] = "⬛️";
                        break;
                    case 3:
                        stringMaze[i, j] = "😇";
                        break;
                    case 6:
                        stringMaze[i, j] = "👿";
                        break;
                    case 9:
                        stringMaze[i, j] = "🟥";
                        break;
                }
            }
        }
        Console.WriteLine("🟪🟪🟪🟪🟪🟪🟪🟪🟪");
        for (int i = 0; i < _height; i++)
        {
            Console.Write("🟪");
            for (int j = 0; j < _width; j++)
            {
                Console.Write(stringMaze[i, j]);
            }
            Console.WriteLine("🟪");
        }
        Console.WriteLine("🟪🟪🟪🟪🟪🟪🟪🟪🟪");
    }
};