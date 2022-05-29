using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service.Database.EntityFaker.Faker;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Group CreateGroup(FakerArgs fakerArgs)
        {
            using var context = new AssessmentContext();

            var group = _groupFaker.Generate();

            if (fakerArgs.Save)
            {
                context.Groups.Add(group);
                context.SaveChanges();
            }

            return group;
        }

        public static void RemoveGroup(Group group)
        {
            using var context = new AssessmentContext();
            context.Groups.Remove(group);
            context.SaveChanges();
        }

        public static IEnumerable<Group> CreateGroups(EnumerableFakerArgs fakerArgs)
        {
            using var context = new AssessmentContext();

            var groups = new List<Group>(fakerArgs.Count);

            int id = fakerArgs.StartId;
            int count = fakerArgs.Count;
            while (count > 0)
            {
                groups.Add(CreateGroup(new FakerArgs
                {
                    id = id,
                    Save = false,
                }));

                id = groups.Last().GroupId + 1;
                count--;
            }

            if (fakerArgs.Save)
            {
                context.Groups.AddRange(groups);
                context.SaveChanges();
            }

            return groups;
        }

        public static void RemoveGroups(IEnumerable<Group> groups)
        {
            using var context = new AssessmentContext();
            context.Groups.RemoveRange(groups);
            context.SaveChanges();
        }
    }
}
