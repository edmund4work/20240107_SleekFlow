using System;
using InterviewTestAPISleekFlow.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace InterviewTestAPISleekFlow.Database
{
	public class SleekFlowDBContext : DbContext
    {
        public SleekFlowDBContext(DbContextOptions<SleekFlowDBContext> options) : base(options)
        {

        }
        // Todo Table
        public DbSet<tblTodo> tblTodo { get; set; }

        // commonTags Table
        public DbSet<tblCommonTags> tblCommonTags { get; set; }

        // commonStatus Table
        public DbSet<tblCommonStatus> tblCommonStatuses { get; set; }

        // todoTags Table
        public DbSet<tblTodoTags> tblTodoTags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();

                string connectionString = configuration.GetConnectionString("sleekflowdbConnection");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships and constraints here

            // Example: Todo and commonStatus relationship
            modelBuilder.Entity<tblTodo>().HasKey(t => t.Id); // or DeleteBehavior.Cascade depending on your requirements

            // Add other relationships and constraints as needed
        }
    }
}