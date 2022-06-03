using System.Diagnostics;
using System.Linq;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using Model;
using Service.Database;

namespace ViewModel.FormAssessment
{
    public class RequirementViewModel : ViewModelBase
    {
        public Requirement RequirementModel { get; set; }

        private bool _isChecked;
        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                _isChecked = value;
                OnPropertyChanged(nameof(IsChecked));
            }
        }

        public string Title
        {
            get
            {
                if (RequirementModel.Name != null)
                {
                    return RequirementModel.Name;
                }
                else
                {
                    return RequirementModel.Indicator.Name;
                }
            }
        }
        public string Description { get => RequirementModel?.Description!; }
        public IndicatorViewModel Indicator { get => Factory.CreateIndicator(RequirementModel.Indicator); }



        
        public RequirementViewModel(Requirement reqMdl)
        {
            RequirementModel = reqMdl;
            
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
