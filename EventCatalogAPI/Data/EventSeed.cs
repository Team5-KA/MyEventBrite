﻿using EventCatalogAPI.Domain;
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
           //Migrate to database

           eventContext.Database.Migrate();

           if (eventContext.EventTypes.Any())
            {
                eventContext.EventTypes.RemoveRange(eventContext.EventTypes);
                eventContext.SaveChanges();
            }
            if (!eventContext.EventTypes.Any())
            {
                eventContext.EventTypes.AddRange(GetEventTypes());
                eventContext.SaveChanges();
            }

            if (eventContext.EventCategories.Any())
            {
                eventContext.EventCategories.RemoveRange(eventContext.EventCategories);
                eventContext.SaveChanges();
            }
            if (!eventContext.EventCategories.Any())
            {
                eventContext.EventCategories.AddRange(GetEventCategories());
                eventContext.SaveChanges();
            }

            if (eventContext.EventSubCategories.Any())
            {
                eventContext.EventSubCategories.RemoveRange(eventContext.EventSubCategories);
                eventContext.SaveChanges();
            }
            if (!eventContext.EventSubCategories.Any())
            {
                eventContext.EventSubCategories.AddRange(GetEventSubCategories());
                eventContext.SaveChanges();
            }

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

        //Event Types
        private static IEnumerable<EventType> GetEventTypes()
        {
            return new List<EventType>
            {
                new EventType { Type = "Concert or Performance" },
                new EventType { Type = "Festival or Fair" },
                new EventType { Type = "Health & Wellness" }
            };
        }

        //Event Category
        private static IEnumerable<EventCategory> GetEventCategories()
        {
            return new List<EventCategory>
            {
                new EventCategory { Category = "Music" },
                new EventCategory { Category = "Seasonal & Holiday" },
                new EventCategory { Category = "Wellbeing" }
            };
        }

        //Event Subcategory
        private static IEnumerable<EventSubCategory> GetEventSubCategories()
        {
            return new List<EventSubCategory>
            {
                new EventSubCategory { SubCategory = "Father's Day" },
                new EventSubCategory { SubCategory = "Independence Day" },
                new EventSubCategory { SubCategory = "Jazz" },
                new EventSubCategory { SubCategory = "Ariana Grande" },
                new EventSubCategory { SubCategory = "Song Writing" },
                new EventSubCategory { SubCategory = "Mindfulness" },
                new EventSubCategory { SubCategory = "Ayurveda" },
                new EventSubCategory { SubCategory = "Yoga" }
            };
        }

        //Event Data - seeded data.

        private static IEnumerable<EventItem> GetEventItems()
        {
            return new List<EventItem>
            {
                new EventItem
                {
                    Title="Fourth of July Fireworks Show",
                    Description="The July 4, 2020 event starts at 9 p.m., but without a designated viewing area. The fireworks will be launched from the Oroville Airport on the west side of town in 2020, so it will be easier for residents to view the show from their front yards. Viewing is also possible from higher elevation points in the city or around Forebay or Afterbay, all while maintaining social distance from other spectators.",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/1",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 2,

                },
                new EventItem
                {
                    Title="July 4th : A Tribute to the American Spirit Concert",
                    Description="A Tribute to the American Spirit” will highlight the resilience of all Americans, honor our veterans, and celebrate Independence Day with some patriotic favorites.",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/2",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 2,

                },
                new EventItem
                {
                    Title="Creative Academy of Music Composers",
                    Description="Join us for this memorable evening of great music performed by high school students of Lake Washington School District.",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/3",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 2,

                },

                new EventItem
                {
                    Title="Father's Day Special Brunch",
                    Description="Let us serve you our All-you-can-eat brunch favorites this Father's day",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/4",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 1,

                },
                new EventItem
                {
                    Title="Dad & Daughter Dance Party",
                    Description="Dads, this is an opportunity for you to express your love for your daughter and to show her that she is a special treasure who deserves to be treated with kindness and respect. This formal event is for dads and daughters of all ages!",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/5",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 1,

                },
                new EventItem
                {
                    Title="Father's Day Extravaganza!",
                    Description="Join us for a day full of fun activities for families. Activities are free for Dads on the occasion of Father's day.",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/6",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 1,

                },
                new EventItem
                {
                    Title="JazzFest",
                    Description="Enjoy Wonderful Live Music while having Lunch or coffee, soft Latin sounds with some Motown thrown in for Fun!",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/7",
                    EventTypeId = 1,
                    EventCategoryId = 1,
                    EventSubCategoryId = 3,

                },
                new EventItem
                {
                    Title="Ariana Grande Virtual Concert",
                    Description="Ariana grande is performing at the first of its kind Virtual Concert on August 5! Be the first person to book your tickets!",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/8",
                    EventTypeId = 1,
                    EventCategoryId = 1,
                    EventSubCategoryId = 4,

                },
                new EventItem
                {
                    Title="Free Songwriters Workshop",
                    Description="This free online songwriting workshop for non-professional songwriters will be a fun challenge. Get free songwriting tips and techniques from passionate fellow songwriters from all around the world.",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/9",
                    EventTypeId = 1,
                    EventCategoryId = 1,
                    EventSubCategoryId = 5,
                },
                new EventItem
                {
                    Title="Workshop on Mindfulness",
                    Description="Come experience the stress relieving experience of mindfulness workshop" ,
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/10",
                    EventTypeId = 3,
                    EventCategoryId = 3,
                    EventSubCategoryId = 6,

                },
                new EventItem
                {
                    Title="A talk on Ayurveda",
                    Description="Join us for a talk on Ayurveda - the sister science of Yoga by renowned Guru of Ayurveda",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/11",
                    EventTypeId = 3,
                    EventCategoryId = 3,
                    EventSubCategoryId = 7,

                },
                new EventItem
                {
                    Title="Yoga for all",
                    Description="YogaForAll proudly presents 5th Annual Yoga Day celebration. Please join us for a yoga session with family and friends",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/12",
                    EventTypeId = 3,
                    EventCategoryId = 3,
                    EventSubCategoryId = 8,

                }
            };

        }

    }
}
