using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Examen1.Models;

namespace Examen1.Models
{
    public class Conexion
    {
        readonly SQLiteAsyncConnection _db;
        public Conexion() { }


        public Conexion(String dbpath)
        {
            // Creando una conexion a base de datos sqlite a partir del path de la base de datos
            _db= new SQLiteAsyncConnection(dbpath);

            // Crear las tablas correspondientes en la base de datos de sqlite
            _db.CreateTableAsync<Models.Content_Page>().Wait();
        }

        public Task<int> StoreContactos(Models.Content_Page edad)
        {
            if (edad.Edad != 0)
            {
                return _db.UpdateAsync(edad);
            }
            else
            {
                return _db.InsertAsync(edad);
            }
        }
        // Read

        private Task<List<Models.Content_Page>> listaContactoss()
        {
            return _db.Table<Models.Content_Page>().ToListAsync();
        }

        public Task<Models.Content_Page> getempleado(int pid)
        {
            return _db.Table<Models.Content_Page>()
                .Where(i => i.Edad== pid)
                .FirstOrDefaultAsync();
        }

        public Task<int> DeleteContactos(Models.Content_Page edad)
        {
            return _db.DeleteAsync(edad);
        }








    }
}