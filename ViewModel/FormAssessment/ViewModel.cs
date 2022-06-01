using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using Microsoft.Toolkit.Mvvm.Input;

namespace ViewModel
{

    public class ViewModel : INotifyPropertyChanged
    {
        public RelayCommand MyCommand { get; set; }

        public string MyValue
        {
            get => _myValue;
            set
            {
                if (value != _myValue)
                {
                    _myValue = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyValue)));
                }
            }
        }

        private string _myValue = "asdf";

        public event PropertyChangedEventHandler? PropertyChanged;

        public ViewModel()
        {
            MyCommand = new RelayCommand(() =>
            {
                MessageBox.Show(MyValue);
            });
        }
    }
}
