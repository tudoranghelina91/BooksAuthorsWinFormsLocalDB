namespace BooksAuthorsWinFormsLocalDB.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Books
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        public int Year { get; set; }

        public int PublisherId { get; set; }

        public int? AuthorId { get; set; }

        public virtual Authors Authors { get; set; }

        public virtual PublishingHouses PublishingHouses { get; set; }
    }
}
