namespace Lab2;
public class Field
{
    private int[,] maze;
    private int height = 5;
    private int width = 7;
    private int[] pacman = new int[] { 1, 1 };
    private int[] enemy = new int[] { 0, 0 };
    private int[] destPoint = new int[] { 5, 3 };

    private Field(int[,] maze_)
    {
        this.maze = maze_;
    }

    public static Field GetDefaultField() => new(new[,])
    {
        { 6, 1, 1, 1, 1, 1, 1 },
        { 1, 3, 1, 0, 1, 1, 1 },
        { 0, 0, 1, 0, 1, 0, 0 },
        { 1, 1, 1, 0, 1, 9, 1 },
        { 1, 1, 1, 1, 1, 1, 1 },
        
        /*
        🟪🟪🟪🟪🟪🟪🟪🟪🟪
        🟪👿▪️▪️▪️▪️▪️▪️🟪
        🟪▪️😇▪️🟪▪️▪️▪️🟪
        🟪🟪🟪▪️🟪▪️🟪🟪🟪
        🟪▪️▪️▪️🟪▪️❌▪️🟪
        🟪▪️▪️▪️▪️▪️▪️▪️🟪
        🟪🟪🟪🟪🟪🟪🟪🟪🟪
         */
    }

    public void PrintField()
    {
        string[,] stringMaze = new string[height, width];
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                switch (maze[i][j])
                {
                    case 0:
                        stringMaze[i][j] = "🟪";
                        break;
                    case 1:
                        stringMaze[i][j] = "▪";
                        break;
                    case 3:
                        stringMaze[i][j] = "😇";
                        break;
                    case 6:
                        stringMaze[i][j] = "👿";
                        break;
                    case 9:
                        stringMaze[i][j] = "❌"
                }
            }
        }
        Console.WriteLine("🟪🟪🟪🟪🟪🟪🟪🟪🟪");
        for (int i = 0; i < height; i++)
        {
            Console.Write("🟪");
            for (int j = 0; j < width; j++)
            {
                Console.Write(stringMaze[i][j]);
            }
            Console.WriteLine("🟪");
        }
        Console.WriteLine("🟪🟪🟪🟪🟪🟪🟪🟪🟪");
    }
};