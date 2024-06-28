using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Threading;
using MazeLibrary;
using ReactiveUI;

namespace DesktopUI.ViewModel;

public class MainViewModel : ViewModelBase
{
  public uint MazeRows { get; set; } = 1;
  public uint MazeColumns { get; set; } = 1;
  public Maze Maze { get; set; } = Maze.MazeExample;
  public ICommand MazeGenerateCommand { get; }

  public uint CaveRows { get; set; } = 1;
  public uint CaveColumns { get; set; } = 1;

  public MainViewModel()
  {
    MazeGenerateCommand = ReactiveCommand.Create(GenerateMaze);
  }

  public void GenerateMaze()
  {
      Maze = new Maze(MazeRows, MazeColumns);
  }
}