using Model;

namespace Service.Database
{
    public class AssessmentContext
    {
        public List<Project> projects { get; set; }

        public AssessmentContext()
        {
            projects = new List<Project>();
            Project form1 = new Project("OOSDD", 1);
            Project form2 = new Project("Stage/Afstuderen of Project", 1);
            projects.Add(form1);
            projects.Add(form2);
        }

    }
}
