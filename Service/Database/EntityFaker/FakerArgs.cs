namespace Service.Database.EntityFaker
{
    public class FakerArgs
    {
        public int id { get; set; } = 1;
        public bool Save { get; set; } = false;
        public bool RemoveRelated { get; set; } = true;
    }
}
