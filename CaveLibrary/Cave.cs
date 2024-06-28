namespace CaveLibrary;

public class Cave
{
  private bool[,] Cells { get; init; }
  
  public Cave(uint rows, uint columns)
  {
    
  }

  public Cave(bool[,] cells) => Cells = cells;
  
  
}