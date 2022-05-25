using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel.FormAssessment;

namespace ViewModel.GroupAdmin
{
    public class SubjectViewModel : ViewModelBase
    {
        public string Title { get; set; }
        public AssessmentViewModel Assessment { get; set; }

    }
}
