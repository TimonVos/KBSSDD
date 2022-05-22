using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel.FormAssessment
{
    public class RequirementViewModel :ViewModelBase
    {
        public Requirement RequirementModel { get; set; }
        public string Title { get => RequirementModel.Name; }
        public string Description { get => RequirementModel.Description; }
        public IndicatorViewModel Indicator { get => Factory.CreateIndicator(RequirementModel.Indicator); }
    }
}
