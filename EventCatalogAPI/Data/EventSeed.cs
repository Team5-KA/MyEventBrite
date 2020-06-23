using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Data
{
    public static class EventSeed
    {
        public static void Seed(EventContext eventContext)
        {
            eventContext.Database.Migrate();
            if (eventContext.EventItems.Any())
            {
                eventContext.EventItems.RemoveRange(eventContext.EventItems);
                eventContext.SaveChanges();
            }   
            if (!eventContext.EventItems.Any()) 
            {
                eventContext.EventItems.AddRange(GetEventItems());
                eventContext.SaveChanges();
            }

        }

        private static IEnumerable<EventItem> GetEventItems()
        {
            return new List<EventItem>
            {
                new EventItem{Title="Fourth of July Fireworks Show",Description="The July 4, 2020 event starts at 9 p.m., but without a designated viewing area. The fireworks will be launched from the Oroville Airport on the west side of town in 2020, so it will be easier for residents to view the show from their front yards. Viewing is also possible from higher elevation points in the city or around Forebay or Afterbay, all while maintaining social distance from other spectators.",PictureUrl="http://externaleventbaseurltobereplaced/api/pic/1"},
                new EventItem{Title="July 4th : A Tribute to the American Spirit Concert",Description="A Tribute to the American Spirit” will highlight the resilience of all Americans, honor our veterans, and celebrate Independence Day with some patriotic favorites.",PictureUrl="http://externaleventbaseurltobereplaced/api/pic/2"},
                new EventItem{Title="Creative Academy of Music Composers",Description="Join us for this memorable evening of great music performed by high school students of Lake Washington School District.",PictureUrl="http://externaleventbaseurltobereplaced/api/pic/3"},
                new EventItem {Title="Father's Day Special Brunch",Description="Let us serve you our All-you-can-eat brunch favorites this Father's day",PictureUrl="http://externaleventbaseurltobereplaced/api/pic/4"},
                new EventItem {Title="Dad & Daughter Dance Party",Description="Dads, this is an opportunity for you to express your love for your daughter and to show her that she is a special treasure who deserves to be treated with kindness and respect. This formal event is for dads and daughters of all ages!",PictureUrl="http://externaleventbaseurltobereplaced/api/pic/5"},
                new EventItem {Title="Father's Day Extravaganza!",Description="Join us for a day full of fun activities for families. Activities are free for Dads on the occasion of Father's day.",PictureUrl="http://externaleventbaseurltobereplaced/api/pic/6"},
                new EventItem{Title="JazzFest",Description="Enjoy Wonderful Live Music while having Lunch or coffee, soft Latin sounds with some Motown thrown in for Fun!",PictureUrl="http://externaleventbaseurltobereplaced/api/pic/7"},
                new EventItem{Title="Ariana Grande Virtual Concert",Description="Ariana grande is performing at the first of its kind Virtual Concert on August 5! Be the first person to book your tickets!",PictureUrl="http://externaleventbaseurltobereplaced/api/pic/8"},
                new EventItem{Title="Free Songwriters Workshop",Description="This free online songwriting workshop for non-professional songwriters will be a fun challenge. Get free songwriting tips and techniques from passionate fellow songwriters from all around the world.",PictureUrl="http://externaleventbaseurltobereplaced/api/pic/9"},
            };

        }

    }
}
