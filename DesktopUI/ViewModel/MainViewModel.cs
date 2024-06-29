using System;
using System.ComponentModel;
using Avalonia.Media;
using CaveLibrary;
using CommunityToolkit.Mvvm.ComponentModel;
using MazeLibrary;
using ReactiveUI;

namespace DesktopUI.ViewModel;

public class MainViewModel : ReactiveObject, INotifyPropertyChanged
{
  private Maze _maze = MazeLibrary.Maze.MazeExample;

  public Maze Maze
  {
    get => _maze;
    set
    {
      _maze = value;
      OnPropertyChanged(nameof(Maze));
    }
  }
  public uint MazeRows { get; set; } = 1;
  public uint MazeColumns { get; set; } = 1;
  
  
  private Cave _cave = Cave.ExampleCave;

  public Cave Cave
  {
    get => _cave;
    set
    {
      _cave = value;
      OnPropertyChanged(nameof(Cave));
    }
  }
  
  public uint CaveRows { get; set; } = 1;
  public uint CaveColumns { get; set; } = 1;
  
  public void GenerateMaze()
  {
    Maze = new Maze(MazeRows, MazeColumns);
  }
  
  public void GenerateCave()
  {
    Cave = new Cave(CaveRows, CaveColumns);
  }
  
  public new event PropertyChangedEventHandler? PropertyChanged;

  protected virtual void OnPropertyChanged(string propertyName)
  {
    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }
}