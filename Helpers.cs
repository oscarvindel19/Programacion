using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Examen1.Models;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace Examen1
{
    public class Helpers
    {
        SQLiteAsyncConnection db;
        public Helpers(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Content_Page>().Wait();
        }

        public Task<int> SaveContactos(Content_Page edad)
        {
            
                return db.InsertAsync(edad);
            
               
            }

        }
    }
