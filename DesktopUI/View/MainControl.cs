namespace DesktopUI;

using MazeLibrary;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

public class MainControl : Control
{
  public static readonly StyledProperty<Maze> MazeProperty =
    AvaloniaProperty.Register<MainControl, Maze>(nameof(Maze));

  public Maze Maze
  {
    get => GetValue(MazeProperty);
    set => SetValue(MazeProperty, value);
  }

  public override void Render(DrawingContext context)
  {
    base.Render(context);

    var rows = Maze.Rows;
    var columns = Maze.Columns;
    var cellWidth = Bounds.Width / columns;
    var cellHeight = Bounds.Height / rows;
    
    var pen = new Pen(Brushes.White, 2);
    for (uint row = 0; row < rows; row++)
    {
      for (uint column = 0; column < columns; column++)
      {
        if (Maze.HasRightWall(row, column))
        {
          var x1 = (column + 1) * cellWidth;
          var y1 = row * cellHeight;
          var y2 = (row + 1) * cellHeight;
          context.DrawLine(pen, new Point(x1, y1), new Point(x1, y2));
        }
        
        if (Maze.HasBottomWall(row, column))
        {
          var x1 = column * cellWidth;
          var x2 = (column + 1) * cellWidth;
          var y1 = (row + 1) * cellHeight;
          context.DrawLine(pen, new Point(x1, y1), new Point(x2, y1));
        }
      }
    }
  }
}
