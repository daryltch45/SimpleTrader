using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Packaging;
using System.Text;

namespace SimpleTrader.WPF.Models
{
    public class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}
