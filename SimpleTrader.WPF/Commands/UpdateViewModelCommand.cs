using SimpleTrader.WPF.State.Navigator;
using SimpleTrader.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SimpleTrader.WPF.Commands
{
  // We can do the same thing using RelayCommand(Try later)
  public class UpdateViewModelCommand : ICommand
  {
    public event EventHandler CanExecuteChanged;
    private INavigator _navigator;

    public UpdateViewModelCommand(INavigator navigator)
    {
        _navigator = navigator;
    }

    public bool CanExecute(object parameter)
    {
      return true;
    }

    public void Execute(object parameter)
    {
      if(parameter is ViewType)
      {
        ViewType viewType = (ViewType)parameter;
        switch(viewType)
        {
          case ViewType.Home:
            _navigator.CurrentViewModel = new HomeViewModel();
            break;

          case ViewType.Portfolio:
            _navigator.CurrentViewModel = new PortfolioViewModel();
            break;

          default:
            break;
        }
      }
    }
  }
}
