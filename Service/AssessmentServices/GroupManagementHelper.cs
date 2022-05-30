using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service.Database;

namespace Service.AssessmentServices
{
    public class GroupManagementHelper
    {
        public void AddGroup(Group group, Project project)
        {
            AssessmentContext assessmentContext = new AssessmentContext();
            assessmentContext.Groups.Add(group);
            Assessment assessmentTemp = new Assessment();
            assessmentTemp.Group = group;
            assessmentTemp.Project = project;
            assessmentContext.Assessments.Add(assessmentTemp);
            assessmentContext.SaveChanges();
        }
    }
}
