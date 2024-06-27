namespace MazeLibrary;

public class Maze
{
  private bool[,] RightWalls { get; init; }
  private bool[,] BottomWalls { get; init; }
  public uint Rows => (uint)RightWalls.GetLength(0);
  public uint Columns => (uint)RightWalls.GetLength(1);

  // Генерация лабиринта
  public Maze(uint rows, uint columns)
  {
    
  }
  
  // Открытие из файла. Пример(размер матрицы, право, низ):
  // 4 4
  // 0 0 0 1
  // 1 0 1 1
  // 0 1 0 1
  // 0 0 0 1
  //
  // 1 0 1 0
  // 0 0 1 0
  // 1 1 0 1
  // 1 1 1 1
  public Maze()
  {
    
  }
  
  public bool HasRightWall(uint row, uint column) => RightWalls[row, column];
  public bool HasLeftWall(uint row, uint column) => column == 0 || RightWalls[row, column - 1];
  public bool HasTopWall(uint row, uint column) => row == 0 || BottomWalls[row - 1, column];
  public bool HasBottomWall(uint row, uint column) => BottomWalls[row, column];

  
  
  
  
  // Просто переменная для тестов отрисовки
  public static Maze MazeExample = new Maze(0,0)
  {
    RightWalls = new bool[,] {{false, false, true},
                              {false, false, true},
                              {true, false, true}},
    BottomWalls = new bool[,] {{true, false, true},
                              {false, true, false},
                              {true, false, true}}
  };
}