namespace Model
{
    /// <summary>
    /// Model for the knock out criteria that a project needs to accomplish to be assessed
    /// </summary>
    public class ControlQuestion
    {
        public ControlQuestion(int formId, Form form, string question)
        {
            FormId = formId;
            Form = form;
            Question = question;
        }

        public int FormId { get; set; }
        public Form Form { get; set; }
        public string Question { get; set; }
    }
}
