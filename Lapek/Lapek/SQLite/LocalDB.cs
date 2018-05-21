using Lapek.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lapek.SQLite
{
    public class LocalDB
    {
        readonly SQLiteAsyncConnection database;
        public LocalDB(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<CartItemModel>().Wait();
        }

        public Task<List<CartItemModel>> GetItemsAsync()
        {
            return database.Table<CartItemModel>().ToListAsync();
        }
        public Task<int> AddItemAsync(CartItemModel item)
        {
            return database.InsertAsync(item);
        }
        public Task<int> UpdateItemAsync(CartItemModel item)
        {
            return database.UpdateAsync(item);
        }
        public Task<int> DeleteItemAsync(CartItemModel item)
        {
            return database.DeleteAsync(item);
        }
        public void DeleteAllItemsAsync()
        {
            database.DropTableAsync<CartItemModel>().Wait();
            database.CreateTableAsync<CartItemModel>().Wait();
        }
        
    }
}
