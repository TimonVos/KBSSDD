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
        public static Student CreateStudent(FakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new FakerArgs();
            using var context = new AssessmentContext();

            while (context.Students.Any(s => s.StudentNumber == fakerArgs.id))
                fakerArgs.id++;

            var student = _studentFaker.Generate();
            student.StudentNumber = fakerArgs.id;

            if (fakerArgs.Save)
                Save(student);

            return student;
        }

        public static void Save(Student student)
        {
            using var context = GetContext();
            context.Students.Add(student);
            context.SaveChanges();
        }

        public static void Update(Student student)
        {
            using var context = GetContext();
            context.Students.Add(student);
            context.SaveChanges();
        }

        public static void Remove(Student student)
        {
            using var context = GetContext();
            context.Students.Remove(student);
            context.SaveChanges();
        }

        public static IEnumerable<Student> CreateStudents(EnumerableFakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new EnumerableFakerArgs();
            using var context = new AssessmentContext();

            var students = new List<Student>(fakerArgs.Count);

            int id = fakerArgs.StartId;
            int count = fakerArgs.Count;
            while (count > 0)
            {
                students.Add(CreateStudent(new FakerArgs
                {
                    id = id,
                    Save = false,
                }));

                id = students.Last().StudentNumber + 1;
                count--;
            }

            if (fakerArgs.Save)
            {
                context.Students.AddRange(students);
                context.SaveChanges();
            }

            return students;
        }

        public static void SaveRange(IEnumerable<Student> students)
        {
            using var context = GetContext();
            context.Students.AddRange(students);
            context.SaveChanges();
        }

        public static void UpdateRange(IEnumerable<Student> students)
        {
            using var context = GetContext();
            context.Students.AddRange(students);
            context.SaveChanges();
        }

        public static void RemoveRange(IEnumerable<Student> students)
        {
            using var context = GetContext();
            context.Students.RemoveRange(students);
            context.SaveChanges();
        }
    }

    public partial class EntityFakerContained
    {
        public Container<Student> CreateStudent(FakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new FakerArgs();
            fakerArgs.Save = false;

            var student = EntityFaker.CreateStudent(fakerArgs);
            return new Container<Student>(student,
                () => EntityFaker.Save(student),
                () => EntityFaker.Update(student),
                () => EntityFaker.Remove(student)
            );
        }

        public Container<IEnumerable<Student>> CreateStudents(EnumerableFakerArgs? fakerArgs = null)
        {
            fakerArgs ??= new EnumerableFakerArgs();
            fakerArgs.Save = false;

            var students = EntityFaker.CreateStudents(fakerArgs);
            return new Container<IEnumerable<Student>>(students,
                () => EntityFaker.SaveRange(students),
                () => EntityFaker.UpdateRange(students),
                () => EntityFaker.RemoveRange(students)
            );
        }
    }
}
