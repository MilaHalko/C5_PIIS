namespace Pacman.Classes;
public class Field
{
    private int[,] _maze;
    public int Height { get; } = 5;
    public int Width { get; } = 7;
    
    public int this[int x, int y] => _maze[x, y];
    public int this[Cell cell] => _maze[cell.X, cell.Y];

    private Field(int[,] maze)
    {
        this._maze = maze;
    }

    public static Field GetDefaultField() => new Field(new[,]
    {
        { 1, 1, 1, 1, 1, 1, 1 },
        { 1, 1, 1, 0, 1, 1, 1 },
        { 0, 0, 1, 0, 1, 0, 0 },
        { 1, 1, 1, 0, 1, 1, 1 },
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
};