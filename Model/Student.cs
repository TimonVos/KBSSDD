namespace Model
{
    public class Student
    {
        public Student(int studentId, string studentName)
        {
            StudentId = studentId;
            StudentName = studentName;
            this.Groups = new HashSet<ProjectGroup>();
        }
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public virtual ICollection<ProjectGroup> Groups { get; set; }

    }
}
