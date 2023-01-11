using SimpleTrader.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SimpleTrader.WPF
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {
    //Better to set up the StartUp uri here. (For Advantages see: Dependency Injections)
    protected override void OnStartup(StartupEventArgs e)
    {
      Window window = new MainWindow();
      window.DataContext = new MainViewModel();
      window.Show();
      base.OnStartup(e);
    }
  }
}
