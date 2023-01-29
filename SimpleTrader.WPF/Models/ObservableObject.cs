using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SimpleTrader.WPF.Models
{
  public class ObservableObject
  {
    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
      PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
