namespace Service.Database.EntityFaker
{
    /// <summary>
    /// Base class for faker arguments.
    /// </summary>
    public class FakerArgs
    {
        /// <summary>
        /// Primary key of the model.
        /// </summary>
        public int id { get; set; } = 1;
        /// <summary>
        /// Whether save the model after its creation or not.
        /// </summary>
        public bool Save { get; set; } = false;
        /// <summary>
        /// Whether to remove all related data or not throughout the hierarchy.
        /// </summary>
        public bool RemoveRelated { get; set; } = true;
    }
}
