﻿using SimpleTrader.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace SimpleTrader.WPF.State.Navigator
{
  public enum ViewType
  {
    Home,
    Portfolio
  }
  public interface INavigator
  {
    ViewModelBase CurrentViewModel { get; set; }
    ICommand UpdateCurrentViewModelCommand { get; }
  }
}
