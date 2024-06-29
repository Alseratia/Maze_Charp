namespace CaveLibrary;

public class Cave
{
  private bool[,] Cells { get; init; }
  
  public Cave(uint rows, uint columns)
  {
    Cells = new bool[rows, columns];
  }

  public Cave(bool[,] cells) => Cells = cells;
  
  public uint Rows => (uint)Cells.GetLength(0);
  public uint Columns => (uint)Cells.GetLength(1);

  public bool IsLive(uint row, uint column) => Cells[row, column];


  public static Cave ExampleCave = new Cave(0, 0)
  {
    Cells = new bool[,] {
      {true, false, true},
      {false, true,false},
      {true, true, true},
      {false,false,false}
    }
  };


}