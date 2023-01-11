using SimpleTrader.WPF.Commands;
using SimpleTrader.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Xml.XPath;

namespace SimpleTrader.WPF.State.Navigator
{
    public class Navigator : INavigator
    {
        public ViewModelBase CurrentViweModel { get; set; }

        public ICommand UpdateCurrentViewModelCommand => new UpdateViewModelCommand(this); //this is the navigator
    }
}
