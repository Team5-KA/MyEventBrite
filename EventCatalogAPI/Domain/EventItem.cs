using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class EventItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }

    /*  public int EventTypeId { get; set; }
        public int EventCategoryId { get; set; }
        public int EventSubCategoryId { get; set; }

        public int EventOrganizerId { get; set; }

        public EventType EventType { get; set; }
        public EventCategory EventCategory { get; set; }
        public EventSubCategory EventSubCategory { get; set; }

        public EventLocation EventLocation { get; set; }
        public EventDateAndTime EventDateAndTime { get; set; }

        public EventOrganizer EventOrganizer { get; set; }  */
    }
}
