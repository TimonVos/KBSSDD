namespace Model
{
    /// <summary>
    /// Join table of student and student.
    /// </summary>
    public class GroupStudent
    {
        /// <summary>
        /// Primary and foreign key of group.
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Corresponding group entity.
        /// </summary>
        public Group Group { get; set; } = null!;
        /// <summary>
        /// Primary and foreign key of group.
        /// </summary>
        public int StudentNumber { get; set; }
        /// <summary>
        /// Corresponding student entity.
        /// </summary>
        public Student Student { get; set; } = null!;
    }
}
