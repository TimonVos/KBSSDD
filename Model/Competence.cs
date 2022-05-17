namespace Model
{
    /// <summary>
    /// Model for the competences on an assessment form.
    /// </summary>
    public class Competence
    {
        public Competence(int competenceId, string competenceName, string competenceDescription, int competenceWeight, int formId, ICollection<AppearsFrom> appearsFrom, ICollection<Criterion> criteriums)
        {
            CompetenceId = competenceId;
            CompetenceName = competenceName;
            CompetenceDescription = competenceDescription;
            CompetenceWeight = competenceWeight;
            FormId = formId;
            Criteriums = criteriums;
            this.AppearsFrom = new HashSet<AppearsFrom>();
        }

        public int CompetenceId { get; set; }
        public string CompetenceName { get; set; }
        public string CompetenceDescription { get; set; }
        public int CompetenceWeight { get; set; }

        public int FormId { get; set; }
        public ICollection<AppearsFrom> AppearsFrom { get; set; } 
        public ICollection<Criterion> Criteriums { get; set; }
    }
}
