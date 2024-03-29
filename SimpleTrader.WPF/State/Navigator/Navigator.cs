﻿using SimpleTrader.WPF.Commands;
using SimpleTrader.WPF.Models;
using SimpleTrader.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using System.Xml.XPath;

namespace SimpleTrader.WPF.State.Navigator
{
  public class Navigator : ObservableObject, INavigator, INotifyPropertyChanged
  {
    private ViewModelBase _currentViewModel;
    
    public ViewModelBase CurrentViewModel 
    { 
      get
      {
        return _currentViewModel;
      }
      set 
      {
        _currentViewModel = value;
        OnPropertyChanged(nameof(CurrentViewModel));
      }
    }

    public ICommand UpdateCurrentViewModelCommand => new UpdateViewModelCommand(this); //this is the navigator ;)

  }
}
