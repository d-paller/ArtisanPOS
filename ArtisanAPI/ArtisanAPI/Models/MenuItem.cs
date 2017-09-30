namespace ArtisanAPI.Models
{
    public class MenuItem
    {
        /// <summary>
        /// The unique id for the menu item
        /// </summary>
        public int MenuItemId { get; set; }

        /// <summary>
        /// The name of the menu item
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Bool value of whether this item is active or not
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Decimal price of the item
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Short description of the item
        /// </summary>
        public string Desription { get; set; }

    }
}
