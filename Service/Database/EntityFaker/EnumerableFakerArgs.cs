namespace Service.Database.EntityFaker
{
    /// <summary>
    /// Base class for collectible fakers.
    /// </summary>
    public class EnumerableFakerArgs
    {
        /// <summary>
        /// Number of instances to create.
        /// </summary>
        public int Count { get; set; } = 3;
        /// <summary>
        /// The starting primary key.
        /// </summary>
        public int StartId { get; set; } = 1;
        /// <summary>
        /// Whether to save the collection to the database or not.
        /// </summary>
        public bool Save { get; set; } = false;
        /// <summary>
        /// Whether to remove all related data or not throughout the hierarchy.
        /// </summary>
        public bool RemoveRelated { get; set; } = true;
    }
}
