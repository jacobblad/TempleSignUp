using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TempleSignUp.Models.ViewModels;

namespace TempleSignUp.Models
{
    //populating the database with data
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            TempleDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<TempleDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            //Adding a new group
            if (!context.Groups.Any())
            {
                context.Groups.AddRange(

                    new Group
                    {
                        Name = "Aaron Burr",
                        Size = 12,
                        Email = "ikilledham@hotmail.com",
                        Phone = "801-123-1776"
                    });
            }
            //Populating the available times
            if (!context.AvailableTimes.Any())
            {
                context.AvailableTimes.AddRange(

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("8:00 AM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("9:00 AM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("10:00 AM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("11:00 AM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("12:00 PM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("1:00 PM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("2:00 PM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("3:00 PM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("4:00 PM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("5:00 PM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("6:00 PM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("7:00 PM"),
                    },

                    new AvailableTime
                    {
                        TimeSlot = DateTime.Parse("8:00 PM"),
                    }

                );

                context.SaveChanges();
            }
        }
        }
}
