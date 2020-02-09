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
                .HasMany(e => e.Books)
                .WithOptional(e => e.Authors)
                .HasForeignKey(e => e.AuthorId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<PublishingHouses>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PublishingHouses>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.PublishingHouses)
                .HasForeignKey(e => e.PublisherId);
        }
    }
}
