using Microsoft.EntityFrameworkCore;
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

            Assessment assessmentTemp = new Assessment();
            assessmentTemp.Group = group;
            assessmentTemp.ProjectId = project.ProjectId;
            assessmentContext.Assessments.Add(assessmentTemp);


            assessmentContext.SaveChanges();
        }

        public void RemoveGroup(Group group)
        {
            using var assessmentContext = new AssessmentContext();
            assessmentContext.Groups.Remove(group);


            assessmentContext.SaveChanges();
        }

        public void ChangeGroupName(Group group, string newName, int newNumber)
        {
            using var assessmentContext = new AssessmentContext();
            assessmentContext.Groups.Where(grp => grp == group).FirstOrDefault().Name = newName;
            assessmentContext.Groups.Where(grp => grp == group).FirstOrDefault().Number = newNumber;

            assessmentContext.SaveChanges();
        }

        public void AddStudent(Student student, Group selectedGroup)
        {
            using var assessmentContext = new AssessmentContext();
            if (!assessmentContext.Students.Contains(student))
            {
                assessmentContext.Students.Add(student);
            }

            assessmentContext.SaveChanges();

            assessmentContext.Groups.Where(grp => grp == selectedGroup).FirstOrDefault().Students.Add(assessmentContext.Students.Where(std => std.StudentNumber == student.StudentNumber).FirstOrDefault());
            assessmentContext.Students.Where(std => std == student).FirstOrDefault().Groups.Add(assessmentContext.Groups.Where(grp => grp == selectedGroup).FirstOrDefault());

            assessmentContext.SaveChanges();
        }

        public void RemoveStudent(Student selectedStudent, Group selectedGroup)
        {
            using var assessmentContext = new AssessmentContext();

            if (assessmentContext.GroupStudents.Where(grpstd => grpstd.StudentNumber == assessmentContext.Students.Where(std => std.StudentNumber == selectedStudent.StudentNumber).Select(std => std.StudentNumber).Count()) > 0)
            {

            }

            //assessmentContext.GroupStudents.Remove()

            assessmentContext.SaveChanges();
        }
    }


}
