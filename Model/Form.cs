namespace Model
{
    /// <summary>
    /// Model for the form to be displayed and used during the assessment of a project
    /// </summary>
    public class Form
    {
        public Form(int formId, ICollection<ControlQuestion> controlQuestions, ICollection<Competence> competences)
        {
            FormId = formId;
            ControlQuestions = controlQuestions;
            Competences = competences;
        }

        public int FormId { get; set; }

        public ICollection<ControlQuestion> ControlQuestions { get; set; }
        public ICollection<Competence> Competences { get; set; }

    }
}
