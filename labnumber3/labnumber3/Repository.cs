using System.Collections.Generic;
using System.Linq;
using labnumber3.Entities;
using SQLite;

namespace labnumber3
{
   
    public class Repository
    {
        private readonly SQLiteConnection _database;
        public Repository(string databasePath)
        {
            _database = new SQLiteConnection(databasePath);
            _database.CreateTable<Order>();
        }

        public int SaveItem(Order item)
        {
            if (item.Id == 0) return _database.Insert(item);

            _database.Update(item);
            return item.Id;
        }

        public IEnumerable<Order> GetItems() => _database.Table<Order>().ToList();

        public void DeleteAll()
        {
            _database.DeleteAll<Order>();
        }
    }
}