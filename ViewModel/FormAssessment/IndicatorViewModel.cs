using Model;

namespace ViewModel.FormAssessment
{
    public class IndicatorViewModel
    {
        public string Title
        {
            get => IndicatorModel.Name;
        }
        public Indicator IndicatorModel { get; set; }

        public IndicatorViewModel(Indicator indiMdl)
        {
            IndicatorModel = indiMdl;
        }

    }
}
