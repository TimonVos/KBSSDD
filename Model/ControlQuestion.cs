namespace Model
{
    /// <summary>
    /// Model for the knock out criteria that a project needs to accomplish to be assessed
    /// </summary>
    public class ControlQuestion
    {
        public int FormId { get; set; }
        public Form Form { get; set; }
        public string Question { get; set; }
    }
}
