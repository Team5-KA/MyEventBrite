namespace EventCatalogAPI.Domain
{
    public class EventSubCategory
    {
        public int Id { get; set; }
        public string SubCategory { get; set; }
        public int EventCategoryId { get; set; }
        public EventCategory EventCategory { get; set; }    
    }
}