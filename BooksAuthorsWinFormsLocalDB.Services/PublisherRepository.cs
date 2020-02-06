using BooksAuthorsWinFormsLocalDB.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksAuthorsWinFormsLocalDB.Services
{
    public class PublisherRepository : BooksAuthorsPersistentContext, IDisposable
    {
        public PublisherRepository() : base()
        {

        }

        public PublishingHouses GetById(int id)
        {
            return booksAuthorsContext.PublishingHouses.Local.FirstOrDefault(p => p.Id == id);
        }

        public BindingList<PublishingHouses> GetAllLocal()
        {
            try
            {
                return booksAuthorsContext.PublishingHouses.Local.ToBindingList();
            }

            catch
            {
                throw;
            }
        }

        public BindingList<PublishingHouses> GetAll()
        {
            booksAuthorsContext.PublishingHouses.Include("Books").Load();
            return booksAuthorsContext.PublishingHouses.Local.ToBindingList();
        }

        public BindingList<PublishingHouses> Reset()
        {
            booksAuthorsContext.Dispose();
            booksAuthorsContext = new BooksAuthorsContext();
            booksAuthorsContext.PublishingHouses.Include("Books").Load();
            return booksAuthorsContext.PublishingHouses.Local.ToBindingList();
        }

        public PublishingHouses Add(PublishingHouses publisher)
        {
            if (publisher.Name.Length < 2 || publisher.Name.Length > 50)
            {
                throw new FormatException("The values for some or all of the entity fields do not meet the minimum or maximum length requirements");
            }

            else
            {
                bool isUnique = true;
                foreach (var p in booksAuthorsContext.PublishingHouses.Local)
                {
                    if (publisher.Name == p.Name && p.Id != publisher.Id)
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    foreach (var p in booksAuthorsContext.PublishingHouses)
                    {
                        if (publisher.Name == p.Name && p.Id != publisher.Id)
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
                    publisher.Id = booksAuthorsContext.PublishingHouses.Local.Last().Id + 1;
                    booksAuthorsContext.PublishingHouses.Add(publisher);
                    return publisher;
                }

                else
                {
                    throw new InvalidOperationException("There are duplicate entries");
                }
            }
        }

        public PublishingHouses Update(PublishingHouses publisher)
        {
            if (publisher.Name.Length < 2 || publisher.Name.Length > 50)
            {
                booksAuthorsContext.Entry(publisher).Reload();
                throw new FormatException("The values for some or all of the entity fields do not meet the minimum or maximum length requirements");
            }

            else
            {
                string originalFirstName = publisher.Name;

                PublishingHouses duplicatePublisher = null;

                foreach (var p in booksAuthorsContext.PublishingHouses.Local)
                {
                    if (publisher.Name == p.Name && p.Id != publisher.Id)
                    {
                        duplicatePublisher = publisher;
                    }
                }

                if (duplicatePublisher == null)
                {
                    foreach (var p in booksAuthorsContext.PublishingHouses)
                    {
                        if (publisher.Name == p.Name && p.Id != publisher.Id)
                        {
                            duplicatePublisher = publisher;
                        }
                    }
                }

                if (duplicatePublisher != null)
                {
                    publisher.Name = originalFirstName;
                    return null;
                }

                return publisher;
            }
        }

        public void SetLocalId(PublishingHouses publisher)
        {
            if (publisher != null && publisher.Id == 0)
            {
                try
                {
                    publisher.Id = booksAuthorsContext.PublishingHouses.Local.Last(p => p.Id != 0).Id + 1;
                }

                catch
                {
                    publisher.Id = 1;
                }
            }
        }

        public void DiscardChanges()
        {
            var changedEntries = booksAuthorsContext.ChangeTracker.Entries().Where(x => x.State == EntityState.Modified);
            var addedEntries = booksAuthorsContext.ChangeTracker.Entries().Where(x => x.State == EntityState.Added);
            var deletedEntries = booksAuthorsContext.ChangeTracker.Entries().Where(x => x.State == EntityState.Deleted);

            foreach (var b in deletedEntries)
            {
                if (b.Entity is PublishingHouses)
                {
                    booksAuthorsContext.PublishingHouses.Attach(b.Entity as PublishingHouses);
                    b.CurrentValues.SetValues(b.OriginalValues);
                    b.State = EntityState.Unchanged;
                }
            }

            foreach (var b in changedEntries)
            {
                if (b.Entity is PublishingHouses)
                {
                    booksAuthorsContext.Entry(b.Entity).Reload();
                    b.CurrentValues.SetValues(b.OriginalValues);
                    b.State = EntityState.Unchanged;
                }
            }

            foreach (var b in addedEntries)
            {
                if (b.Entity is PublishingHouses)
                {
                    booksAuthorsContext.PublishingHouses.Local.Remove(b.Entity as PublishingHouses);
                }
            }
        }

        public PublishingHouses Delete(int id)
        {
            var publisher = booksAuthorsContext.PublishingHouses.FirstOrDefault(p => p.Id == id);
            booksAuthorsContext.PublishingHouses.Remove(publisher);
            return publisher;
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
