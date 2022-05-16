using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

    }
}
