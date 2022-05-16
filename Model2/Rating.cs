namespace Model
{
    public class Rating
    {
        #region Properties

        public string? Description { get; set; }

        #endregion

        public override string ToString()
        {
            return Description;
        }
    }
}
