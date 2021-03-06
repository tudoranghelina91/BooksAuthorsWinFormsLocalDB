namespace BooksAuthorsWinFormsLocalDB.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BooksAuthorsContext : DbContext
    {
        public BooksAuthorsContext()
            : base("name=BooksAuthorsContext")
        {
        }

        public virtual DbSet<Authors> Authors { get; set; }
        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<PublishingHouses> PublishingHouses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Authors>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Authors>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Authors>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Authors)
                .HasForeignKey(e => e.AuthorId);

            modelBuilder.Entity<Books>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<PublishingHouses>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<PublishingHouses>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.PublishingHouses)
                .HasForeignKey(e => e.PublisherId);
        }
    }
}
