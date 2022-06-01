using Model;

namespace Service.Database.EntityFaker.Args
{
    public class CriteriaArgs : EnumerableFakerArgs
    {
        public Competence Competence
        {
            get => _competence; set
            {
                if (value != _competence)
                {
                    _competence = value;
                    RemoveRelated = false;
                }
            }
        }
        private Competence _competence = EntityFaker.CreateCompetence();
    }
}
