using BooksAuthorsWinFormsLocalDB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAuthorsWinFormsLocalDB.Services
{
    public class AuthorRepository : BooksAuthorsPersistentContext, IDisposable
    {
        public AuthorRepository() : base()
        {

        }

        public Authors GetById(int id)
        {
            return booksAuthorsContext.Authors.Local.FirstOrDefault(a => a.Id == id);
        }        

        public BindingList<Authors> GetAllLocal()
        {
            try
            {
                return booksAuthorsContext.Authors.Local.ToBindingList();
            }

            catch
            {
                throw;
            }
        }

        public BindingList<Authors> GetAll()
        {
            booksAuthorsContext.Authors.Include("Books").Load();
            return booksAuthorsContext.Authors.Local.ToBindingList();
        }

        public BindingList<Authors> Reset()
        {
            booksAuthorsContext.Dispose();
            booksAuthorsContext = new BooksAuthorsContext();
            booksAuthorsContext.Authors.Include("Books").Load();
            return booksAuthorsContext.Authors.Local.ToBindingList();
        }

        public Authors Add(Authors author)
        {
            if (author.FirstName.Length < 2 || author.FirstName.Length > 16 || author.LastName.Length < 2 || author.LastName.Length > 16)
            {
                throw new FormatException("The values for some or all of the entity fields do not meet the minimum or maximum length requirements");
            }

            else
            {
                bool isUnique = true;
                foreach (var a in booksAuthorsContext.Authors.Local)
                {
                    if (author.FirstName == a.FirstName && author.LastName == a.LastName && a.Id != author.Id)
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    foreach (var a in booksAuthorsContext.Authors)
                    {
                        if (author.FirstName == a.FirstName && author.LastName == a.LastName && a.Id != author.Id)
                        {
                            isUnique = false;
                            break;
                        }
                    }
                }

                else
                {
                    throw new InvalidOperationException("There are duplicate entries");
                }

                if (isUnique)
                {
                    author.Id = booksAuthorsContext.Authors.Local.Last().Id + 1;
                    booksAuthorsContext.Authors.Add(author);
                    return author;
                }

                else
                {
                    throw new InvalidOperationException("There are duplicate entries");
                }
            }
        }

        public Authors Update(Authors author)
        {
            if (author.FirstName.Length < 2 || author.FirstName.Length > 16 || author.LastName.Length < 2 || author.LastName.Length > 16)
            {
                booksAuthorsContext.Entry(author).Reload();
                throw new FormatException("The values for some or all of the entity fields do not meet the minimum or maximum length requirements");
            }

            else
            {
                string originalFirstName = author.FirstName;
                string originalLastName = author.LastName;
                DateTime? originalDateOfBirth = author.DateOfBirth;

                Authors duplicateAuthor = null;

                foreach (var a in booksAuthorsContext.Authors.Local)
                {
                    if (author.FirstName == a.FirstName && author.LastName == a.LastName && a.Id != author.Id)
                    {
                        duplicateAuthor = author;
                    }
                }

                if (duplicateAuthor == null)
                {
                    foreach (var a in booksAuthorsContext.Authors)
                    {
                        if (author.FirstName == a.FirstName && author.LastName == a.LastName && a.Id != author.Id)
                        {
                            duplicateAuthor = author;
                        }
                    }
                }

                if (duplicateAuthor != null)
                {
                    author.FirstName = originalFirstName;
                    author.LastName = originalLastName;
                    author.DateOfBirth = originalDateOfBirth;
                    return null;
                }

                return author;
            }
        }

        public void SetLocalId(Authors author)
        {
            if (author.Id == 0)
            {
                author.Id = booksAuthorsContext.Authors.Local.Last(a => a.Id != 0).Id + 1;
            }
        }

        public void DiscardChanges()
        {
            var changedEntries = booksAuthorsContext.ChangeTracker.Entries().Where(x => x.State == EntityState.Modified);
            var addedEntries = booksAuthorsContext.ChangeTracker.Entries().Where(x => x.State == EntityState.Added);
            var deletedEntries = booksAuthorsContext.ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted);

            foreach (var b in deletedEntries)
            {
                if (b.Entity is Authors)
                {
                    booksAuthorsContext.Authors.Attach(b.Entity as Authors);
                    b.CurrentValues.SetValues(b.OriginalValues);
                    b.State = EntityState.Unchanged;
                }
            }

            foreach (var b in changedEntries)
            {
                if (b.Entity is Authors)
                {
                    booksAuthorsContext.Entry(b.Entity).Reload();
                    b.CurrentValues.SetValues(b.OriginalValues);
                    b.State = EntityState.Unchanged;
                }
            }

            foreach (var b in addedEntries)
            {
                if (b.Entity is Authors)
                {
                    booksAuthorsContext.Authors.Local.Remove(b.Entity as Authors);
                }
            }
        }


        public Authors Delete(int id)
        {
            var author = booksAuthorsContext.Authors.FirstOrDefault(a => a.Id == id);
            booksAuthorsContext.Authors.Remove(author);
            return author;
        }

        public void ResetDb()
        {
            try
            {
                booksAuthorsContext.Database.ExecuteSqlCommand("EXEC dbo.ReseedInitialData");
            }

            catch
            {
                throw;
            }
        }

        public void Dispose()
        {
            booksAuthorsContext.Dispose();
        }
    }
}
