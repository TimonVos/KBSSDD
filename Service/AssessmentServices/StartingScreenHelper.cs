using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Database;

namespace Service.AssessmentServices
{
    public class StartingScreenHelper
    {

        public void AddNewProject(string projectName, string projectCode, bool formID)
        {
            using var assessmentContext = new AssessmentContext();
            if (formID)
            {
                assessmentContext.Projects.Add(new Model.Project { Name = projectName, Code = projectCode, FormId = 2 });
            } else
            {
                assessmentContext.Projects.Add(new Model.Project { Name = projectName, Code = projectCode, FormId = 1 });
            }
           

            assessmentContext.SaveChanges();
        }
    }
}
