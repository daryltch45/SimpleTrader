using SimpleTrader.WPF.State.Navigator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleTrader.WPF.ViewModels
{
  public class MainViewModel : ViewModelBase
  {
    public INavigator Navigator { get; set; } = new Navigator();
    //public HomeViewModel HomeViewModel { get; set; } = new HomeViewModel();
    //public PortfolioViewModel PortfolioViewModel { get; set; } = new PortfolioViewModel();
  }
}
