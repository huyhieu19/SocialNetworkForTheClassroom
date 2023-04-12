using Database.Configuration;
using Database.Extentions;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.EF
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configure using fluent API
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.Seed();
        }


        public virtual DbSet<ChatGroup> ChatGroups { get; set; } = null!;
        public virtual DbSet<ChatGroupStudent> ChatGroupStudents { get; set; } = null!;
        public virtual DbSet<ChatGroupTeacher> ChatGroupTeachers { get; set; } = null!;
        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<CommentStudent> CommentStudents { get; set; } = null!;
        public virtual DbSet<CommentTeacher> CommentTeachers { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<ImageNewsFeed> ImageNewsFeeds { get; set; } = null!;
        public virtual DbSet<NewsFeed> NewsFeeds { get; set; } = null!;
        public virtual DbSet<NewsFeedImages> NewsFeedImages { get; set; } = null!;
        public virtual DbSet<NewsFeedStudent> NewsFeedStudents { get; set; } = null!;
        public virtual DbSet<NewsFeedTeacher> GetNewsFeedTeachers { get; set; } = null!;
        public virtual DbSet<Score> Scores { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
    }
}
