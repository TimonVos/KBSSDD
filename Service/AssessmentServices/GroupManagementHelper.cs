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
            using var assessmentContext = new AssessmentContext();
            //assessmentContext.Groups.Add(group);

            assessmentContext.Groups.Add(group);

            /* Assessment assessmentTemp    = new Assessment();
             * assessmentTemp.Group         = group;
             * assessmentTemp.Project       = project;
             * assessmentContext.Assessments.Add(assessmentTemp);
             */

            assessmentContext.SaveChanges();
        }

        public void RemoveGroup(Group group)
        {
            using var assessmentContext = new AssessmentContext();
            assessmentContext.Groups.Remove(group);


            assessmentContext.SaveChanges();
        }
    }
}
