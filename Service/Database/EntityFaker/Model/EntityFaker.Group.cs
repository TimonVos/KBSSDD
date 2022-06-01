using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Group CreateGroup(FakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new FakerArgs();
            var group = _groupFaker.Generate();

            if (fakerArgs.Save)
                Save(group);

            return group;
        }

        public static void Save(Group group)
        {
            using var context = GetContext();
            context.Groups.Add(group);
            context.SaveChanges();
        }

        public static void Update(Group group)
        {
            using var context = GetContext();
            context.Groups.Add(group);
            context.SaveChanges();
        }

        public static void Remove(Group group)
        {
            using var context = GetContext();
            context.Groups.Remove(group);
            context.SaveChanges();
        }

        public static IEnumerable<Group> CreateGroups(EnumerableFakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new EnumerableFakerArgs();
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
                SaveRange(groups);

            return groups;
        }

        public static void SaveRange(IEnumerable<Group> groups)
        {
            using var context = GetContext();
            context.Groups.AddRange(groups);
            context.SaveChanges();
        }

        public static void UpdateRange(IEnumerable<Group> groups)
        {
            using var context = GetContext();
            context.Groups.AddRange(groups);
            context.SaveChanges();
        }

        public static void RemoveRange(IEnumerable<Group> groups)
        {
            using var context = GetContext();
            context.Groups.RemoveRange(groups);
            context.SaveChanges();
        }
    }

    public partial class EntityFakerContained
    {
        public Container<Group> CreateGroup(FakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new FakerArgs();
            fakerArgs.Save = false;

            var group = EntityFaker.CreateGroup(fakerArgs);
            return new Container<Group>(group,
                () => EntityFaker.Save(group),
                () => EntityFaker.Update(group),
                () => EntityFaker.Remove(group)
            );
        }

        public Container<IEnumerable<Group>> CreateGroups(EnumerableFakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new EnumerableFakerArgs();
            fakerArgs.Save = false;

            var groups = EntityFaker.CreateGroups(fakerArgs);
            return new Container<IEnumerable<Group>>(groups,
                () => EntityFaker.SaveRange(groups),
                () => EntityFaker.UpdateRange(groups),
                () => EntityFaker.RemoveRange(groups)
            );
        }
    }
}
