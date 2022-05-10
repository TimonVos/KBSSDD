using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Model;

namespace ViewModel
{
    public class IndicatorViewModel : INotifyPropertyChanged
    {
        public Indicator? Model { get; set; }
        public CriterionViewModel? Criterion { get; set; }
        public string GroupName { get => Criterion?.ToString() ?? ""; }
        public bool IsCheckd {
            get => _isCheckd;
            set
            {
                if (_isCheckd != value)
                {
                    _isCheckd = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsCheckd)));
                }
            }
        }

        private bool _isCheckd;

        public IndicatorViewModel()
        {

        }

        public override string ToString()
        {
            return Model?.ToString() ?? "-";
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
