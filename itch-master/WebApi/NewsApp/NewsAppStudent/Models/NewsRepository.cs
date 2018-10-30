using System;
using System.Collections.Generic;
using System.Linq;

namespace NewsApp.Models
{
    public class NewsRepository
    {
        private readonly DatabaseContext context;

        public NewsRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public void Add(News news)
        {
            context.Add(news);
            context.SaveChanges();
        }

        public IEnumerable<News> GetAll()
        {
            throw new NotImplementedException();
        }

        public News GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool NewsExist(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(News news)
        {
            throw new NotImplementedException();
        }

        public void RecreateDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
