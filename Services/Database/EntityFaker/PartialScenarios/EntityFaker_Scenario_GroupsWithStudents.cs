using Model;
using Service.Database.EntityFaker.Faker;
using Service.Database.EntityFaker.Scenario;

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
                    count--;
                    if (Faker.Random.Bool())
                        continue;

                    var student = students.ElementAt(Faker.Random.Number(0, students.Count() - 1));

                    if (groupStudents.Any(gs => gs.Group == group && gs.Student == student))
                    {
                        count++;
                        continue;
                    }

                    group.Students.Add(student);
                    var groupStudent = new GroupStudent { Group = group, Student = student };
                    group.GroupStudents.Add(groupStudent);
                    student.GroupStudents.Add(groupStudent);
                    groupStudents.Add(groupStudent);
                }
            }

            var scenario = new GroupsWithStudentsScenario
            {
                Groups = groups,
                Students = students,
                GroupStudents = groupStudents,
            };

            if (scenarioArgs.Save)
                scenario.Save();

            return scenario;
        }
    }

    public class GroupsWithStudentsScenario : ScenarioBase
    {
        public IEnumerable<Group> Groups { get; set; } = new HashSet<Group>();
        public IEnumerable<Student> Students { get; set; } = new HashSet<Student>();
        public IEnumerable<GroupStudent> GroupStudents { get; set; } = new HashSet<GroupStudent>();

        public override void Save()
        {
            using var context = new AssessmentContext();
            context.Groups.AddRange(Groups);
            context.Students.AddRange(Students);
            context.GroupStudents.AddRange(GroupStudents);
            context.SaveChanges();
        }

        public override void Remove()
        {
            throw new NotImplementedException();
        }
    }

    public class GroupsWithStudentsArgs : ScenarioArgs
    {
        public EnumerableFakerArgs groupsArgs { get; set; } = new EnumerableFakerArgs();
        public EnumerableFakerArgs studentsArgs { get; set; } = new EnumerableFakerArgs();
        public int MaxStudentsPerGroup { get; set; } = 6;
        public bool AllowEmptyGroups { get; set; } = true;
        public bool AllowUnassignedStudents { get; set; } = true;

        public GroupsWithStudentsArgs()
        {
            groupsArgs.Save = Save;
            studentsArgs.Save = Save;
        }
    }
}
