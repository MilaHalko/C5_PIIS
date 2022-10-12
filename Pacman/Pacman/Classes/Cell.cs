namespace Pacman.Classes;

public class Cell
{
    public int X { get; set; }
    public int Y { get; set; }

    public Cell()
    {
    }
    public Cell(int x, int y)
    {
        X = x;
        Y = y;
    }

    public bool SameCell(Cell cell)
    {
        return X == cell.X && Y == cell.Y;
    }
}