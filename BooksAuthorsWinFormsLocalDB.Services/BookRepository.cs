using BooksAuthorsWinFormsLocalDB.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BooksAuthorsWinFormsLocalDB.Services
{
    public class BookRepository : BooksAuthorsPersistentContext, IDisposable
    {
        public void DiscardChanges()
        {
            var changedEntries = booksAuthorsContext.ChangeTracker.Entries().Where(x => x.State == EntityState.Modified);
            var addedEntries = booksAuthorsContext.ChangeTracker.Entries().Where(x => x.State == EntityState.Added);
            var deletedEntries = booksAuthorsContext.ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted);

            foreach (var b in deletedEntries)
            {
                if (b.Entity is Books)
                {
                    booksAuthorsContext.Books.Attach(b.Entity as Books);
                    b.CurrentValues.SetValues(b.OriginalValues);
                    b.State = EntityState.Unchanged;
                }
            }

            foreach (var b in changedEntries)
            {
                if (b.Entity is Books)
                {
                    booksAuthorsContext.Entry(b.Entity).Reload();
                    b.CurrentValues.SetValues(b.OriginalValues);
                    b.State = EntityState.Unchanged;
                }
            }

            foreach (var b in addedEntries)
            {
                if (b.Entity is Books)
                {
                    booksAuthorsContext.Books.Remove(b.Entity as Books);
                }
            }
        }

        public IList<Books> GetAllLocal()
        {
            return booksAuthorsContext.Books.ToList();
        }

        public Books GetById(int id)
        {
            return booksAuthorsContext.Books.FirstOrDefault(b => b.Id == id);
        }

        public Books Add(Books book)
        {
            if (book.Title.Length < 5)
            {
                throw new FormatException("The values for some or all of the entity fields do not meet the minimum or maximum length requirements");
            }

            else
            {
                booksAuthorsContext.Books.Add(book);
                return book;
            }
        }

        public Books Delete(int id)
        {
            var book = booksAuthorsContext.Books.FirstOrDefault(b => b.Id == id);
            booksAuthorsContext.Books.Remove(book);
            return book;
        }

        public void Dispose()
        {
            booksAuthorsContext.Dispose();
        }
    }
}
