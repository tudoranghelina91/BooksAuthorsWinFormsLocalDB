using BooksAuthorsWinFormsLocalDB.DAL;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAuthorsWinFormsLocalDB.Services
{
    public abstract class BooksAuthorsPersistentContext
    {
        protected static BooksAuthorsContext booksAuthorsContext;
        public BooksAuthorsPersistentContext()
        {
            if (booksAuthorsContext == null)
            {
                booksAuthorsContext = new BooksAuthorsContext();
                try
                {
                    booksAuthorsContext.Authors.Include("Books").Load();
                    booksAuthorsContext.PublishingHouses.Include("Books").Load();
                    booksAuthorsContext.Books.Load();
                }

                catch
                {
                    throw;
                }
            }
        }

        public void Save()
        {
            try
            {
                booksAuthorsContext.SaveChanges();
            }

            catch
            {
                throw;
            }
        }

        public async Task SaveAsync()
        {
            try
            {
                await booksAuthorsContext.SaveChangesAsync();
            }

            catch
            {
                throw;
            }
        }
    }
}
