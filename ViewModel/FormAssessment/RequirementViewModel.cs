using Model;

namespace ViewModel.FormAssessment
{
    public class RequirementViewModel : ViewModelBase
    {
        public Requirement RequirementModel { get; set; }
        public string Title { get => RequirementModel.Name; }
        public string Description { get => RequirementModel.Description; }
        public IndicatorViewModel Indicator { get => Factory.CreateIndicator(RequirementModel.Indicator); }

        public RequirementViewModel(Requirement reqMdl)
        {
            RequirementModel = reqMdl;
        }
    }
}
