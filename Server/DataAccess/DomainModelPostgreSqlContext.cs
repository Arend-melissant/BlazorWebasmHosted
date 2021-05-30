// using Microsoft.EntityFrameworkCore;  
// using BlazorWebasmHosted.Shared;

  
// namespace BlazorWebasmHosted.Server
// {  
//     public class DomainModelPostgreSqlContext : DbContext  
//     {  
//         public DomainModelPostgreSqlContext(DbContextOptions<DomainModelPostgreSqlContext> options) : base(options)  
//         {  
//         }  
  
//         public DbSet<Student> students { get; set; }  
  
//         protected override void OnModelCreating(ModelBuilder builder)  
//         {  
//             builder.HasDefaultSchema("data");
//             builder.Entity<Student>()
//                 .HasOne(p => p.Class)
//                 .WithMany(b => b.Students);
//             base.OnModelCreating(builder);  
//         }  
//         public override int SaveChanges()  
//         {  
//             ChangeTracker.DetectChanges();  
//             return base.SaveChanges();  
//         }  

//     }  
// } 