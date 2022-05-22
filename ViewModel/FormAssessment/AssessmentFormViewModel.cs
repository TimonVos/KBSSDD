using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Model;
using ViewModel.GroupAdmin;

namespace ViewModel.FormAssessment
{
    public class AssessmentFormViewModel : ViewModelBase
    {
        #region Properties

        public Project Project { get; set; }
        public Assessment Assessment { get; set; }
        public IEnumerable<GroupViewModel> Groups { get; set; }
        public GroupViewModel SelectedGroup { get; set; }
        public CompetenceViewModel SelectedCompetence { get; set; }

        public FormViewModel Form { get; set; }
        #endregion
        public AssessmentFormViewModel()
        {
            Form = Factory.CreateForm(Project.Form);
            List<Group> temp = new List<Group>();
            foreach (Assessment assess in Project.Assessments)
            {
                temp.Add(assess.Group);
            }
            Groups = Factory.CreateGroups(temp);
        }

    }
}
