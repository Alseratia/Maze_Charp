using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using CaveLibrary;

namespace DesktopUI;

public class CaveControl : Control
{
  public static readonly StyledProperty<Cave> CaveProperty =
    AvaloniaProperty.Register<MazeControl, Cave>(nameof(Cave));

  public Cave Cave
  {
    get => GetValue(CaveProperty);
    set => SetValue(CaveProperty, value);
  }
  
  static CaveControl()
  {
    AffectsRender<CaveControl>(CaveProperty);
  }
  
  public override void Render(DrawingContext context)
  {
    base.Render(context);

    var rows = Cave.Rows;
    var columns = Cave.Columns;
    var cellWidth = Bounds.Width / columns;
    var cellHeight = Bounds.Height / rows;
    
    var pen = new Pen(Brushes.White, 2);
    for (uint row = 0; row < rows; row++)
    {
      for (uint column = 0; column < columns; column++)
      {
        var x = column * cellWidth;
        var y = row * cellHeight;

        // Определение цвета заливки в зависимости от состояния клетки
        var brush = Cave.IsLive(row, column) ? Brushes.White : Brushes.Black;

        // Рисование клетки с заливкой и рамкой
        context.FillRectangle(brush, new Rect(x, y, cellWidth, cellHeight));
        context.DrawRectangle(pen, new Rect(x, y, cellWidth, cellHeight));
      }
    }
  }
}