using Model;

namespace Service.Database
{
    public class AssessmentContext
    {
        public IEnumerable<Project> projects { get; set; }

        public AssessmentContext()
        {
            projects = new List<Project>
            {
                new Project("OOSDD", 1),
                new Project("Stage/Afstuderen of Project", 2)

            };
        }

    }
}
