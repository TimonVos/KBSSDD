using Model;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static GroupsWithStudentsScenario CreateScenario_GroupsWithStudents(GroupsWithStudentsArgs? scenarioArgs = null)
        {
            scenarioArgs ??= new GroupsWithStudentsArgs();
            using var context = new AssessmentContext();

            var groups = CreateGroups(scenarioArgs.groupsArgs);
            var students = CreateStudents(scenarioArgs.studentsArgs);
            var groupStudents = new HashSet<GroupStudent>();

            foreach (var group in groups)
            {
                int count = scenarioArgs.MaxStudentsPerGroup;

                while (count > 0 || (scenarioArgs.AllowEmptyGroups == false && group.Students.Count() == 0))
                {
                    var student = students.ElementAt(Faker.Random.Number(0, students.Count() - 1));

                    if (Faker.Random.Bool())
                    {
                        count--;
                        continue;
                    }

                    if (groupStudents.Any(gs => gs.Group == group && gs.Student == student))
                        continue;

                    AssignStudentToGroup(group, student, groupStudents);

                    count--;
                }
            }

            var scenario = new GroupsWithStudentsScenario
            {
                Groups = groups,
                Students = students,
                GroupStudents = groupStudents,
            };

            return scenario;
        }

        private static void AssignStudentToGroup(Group group, Student student, ICollection<GroupStudent> groupStudents)
        {
            group.Students.Add(student);
            var groupStudent = new GroupStudent { Group = group, Student = student };
            group.GroupStudents.Add(groupStudent);
            student.GroupStudents.Add(groupStudent);
            student.Groups.Add(group);
            groupStudents.Add(groupStudent);
        }
    }

    public class GroupsWithStudentsScenario : ScenarioBase<GroupsWithStudentsScenario>
    {
        public IEnumerable<Group> Groups { get; set; } = new HashSet<Group>();
        public IEnumerable<Student> Students { get; set; } = new HashSet<Student>();
        public IEnumerable<GroupStudent> GroupStudents { get; set; } = new HashSet<GroupStudent>();

        protected override void SaveScenario()
        {
            using var context = new AssessmentContext();
            context.Groups.AddRange(Groups);
            context.Students.AddRange(Students);
            context.GroupStudents.AddRange(GroupStudents);
            context.SaveChanges();
        }

        protected override void RemoveScenario()
        {
            using var context = new AssessmentContext();
            context.GroupStudents.RemoveRange(GroupStudents);
            context.Students.RemoveRange(Students);
            context.Groups.RemoveRange(Groups);
            context.SaveChanges();
        }
    }

    public class GroupsWithStudentsArgs : ScenarioArgs
    {
        public EnumerableFakerArgs groupsArgs { get; set; } = new EnumerableFakerArgs();
        public EnumerableFakerArgs studentsArgs { get; set; } = new EnumerableFakerArgs();
        public int MaxStudentsPerGroup { get; set; } = 6;
        public bool AllowEmptyGroups { get; set; } = true;

        public GroupsWithStudentsArgs()
        {
        }
    }
}
