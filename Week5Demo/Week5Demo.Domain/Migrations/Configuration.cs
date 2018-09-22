using System;
using System.Collections.Generic;
using Week5Demo.Domain.Entities;

namespace Week5Demo.Domain.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Week5Demo.Domain.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Week5Demo.Domain.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // Bill Gates
            var student = new Student
            {
                StudentId = Guid.NewGuid(),
                StudentName = "Bill Gates", 
                Height = 6.05m,
                Weight = 167.8f
            };

            context.Students.AddOrUpdate(student);
        }
    }
}
