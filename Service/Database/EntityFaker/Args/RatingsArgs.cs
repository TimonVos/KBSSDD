using Model;

namespace Service.Database.EntityFaker.Args
{
    public class RatingsArgs : EnumerableFakerArgs
    {
        public Assessment Assessment
        {
            get => _assesssment; set
            {
                if (value != _assesssment)
                {
                    _assesssment = value;
                    RemoveRelated = false;
                }
            }
        }
        private Assessment _assesssment = EntityFaker.CreateAssessment();
    }
}
