namespace Model
{
    public class Competence
    {
        #region Properties

        public string? Name { get; set; }
        public string[]? RatedBy { get; set; }
        public List<Criterion>? Criteriums { get; set; }
        public string? Notes { get; set; }
        public override string ToString()
        {
            return Name;
        }

        #endregion
    }
}
