/**
 * Summary: Creates initial database and table for generic object, and handles adding/removing/modifying new entries
 * 
 * 
 */
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeaJournal.Infrastructure;

namespace TeaJournal
{
    /**
     * TODO: SQLite implementation, read/write/update/search
     */
    class DatabaseManager<T> where T : new()
    {
        private static string directory = Path.Combine(Directory.GetCurrentDirectory(), "data");
        private string name;

        public SQLiteConnection database { get; private set; }

        /// <summary>
        /// Creates initial database (if it does not exist already) and adds tables
        /// </summary>
        /// <param name="name"> The database name. </param>
        public DatabaseManager(string name)
        {
            this.name = name;
            Debug.WriteLine("DIRECTORY: " + directory);
            database = InitializeDatabase(database, name, typeof(T));
            //database.Insert(new Tea(Tea.teaType.Green, "Gyokuru", "Extra instructions", "Extra notes"));
            //database.Insert(new Tea(Tea.teaType.Black, "Earl Grey", "Earl Grey instructions", "Earl Grey notes"));
        }

        /// <summary>
        /// Searches database by id and returns an object of generic type.
        /// </summary>
        /// <param name="id"> The ID of the database entry to find.</param>
        /// <returns></returns>
        public T FindData(int id)
        {
            return database.Find<T>(id);
        }

        /// <summary>
        /// Searches database using a query to find multiple entries.
        /// </summary>
        /// <param name="query"> <see cref="Expression"/> to be used as a query on the database.</param>
        /// <returns><see cref="List{T}"/> of found entries in the database.</returns>
        public List<T> FindAllData(Expression<Func<T, bool>> query)
        {
            List<T> found = new List<T>();
            TableQuery<T> entries = database.Table<T>().Where(query);
            foreach (T item in entries)
            {
                found.Add(item);
            }
            return found;
        }

        /// <summary>
        /// Adds table(s) to a given database. Creates a new database if it does not exist already.
        /// </summary>
        /// <param name="db"> The database to create tables for.</param>
        /// <param name="dbName"> The name of our database. </param>
        /// <param name="tables"> List of types of tables to create. </param>
        /// <returns></returns>
        public static SQLiteConnection InitializeDatabase(SQLiteConnection db, string dbName, params Type[] tables)
        {
            if(db == null)
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                db = new SQLiteConnection(Path.Combine(directory, dbName));
            }

            db.CreateTables(CreateFlags.None, tables);

            return db;
        }
    }
}
