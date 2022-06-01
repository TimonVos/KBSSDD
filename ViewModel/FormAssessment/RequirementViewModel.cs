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
        public string Title { get => RequirementModel?.Name!; }
        public string Description { get => RequirementModel?.Description!; }
        public IndicatorViewModel Indicator { get => Factory.CreateIndicator(RequirementModel.Indicator); }



        
        public RequirementViewModel(Requirement reqMdl)
        {
            RequirementModel = reqMdl;
            
        }
    }
}
