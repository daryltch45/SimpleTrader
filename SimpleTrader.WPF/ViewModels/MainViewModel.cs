using SimpleTrader.WPF.State.Navigator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.WPF.ViewModels
{
  public class MainViewModel : ViewModelBase
  {
    public INavigator Navigator { get; set; } = new Navigator();
  }
}
