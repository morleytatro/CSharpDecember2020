using Microsoft.EntityFrameworkCore;

namespace FirstDB.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Monsters" table name will come from the DbSet variable name
        public DbSet<Student> Students { get; set; }

        // if other models, add them as well
        // public DbSet<Course> Courses {get;set;}
    }
}