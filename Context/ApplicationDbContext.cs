using EFwithDB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFwithDB.Context
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // in Data sourse we can use {DESKTOP-0R98A3C\MSSQLSERVER01 , localhoast , .} every one of them is valid


            // ============>>>> This way is Old <<<<============
            /*
             * ======= what UseSqlServer need =======
             * Data Sourse / server name
             * Initial Catalog / database name
             * Integrated Security / to use authintication {True is mean use windows authintication without user ans password}
            */
            /*optionsBuilder.UseSqlServer("Data Sourse=.; Initial Catalog=ASP9_EF;Integrated Security=True");*/

            //=========================================================================================================================================

            // ============>>>> This way is New <<<<============
            /*
             * ======= what UseSqlServer need =======
             * Server / server name
             * Database / database name
             * Trusted_Connection / to use authintication {True is mean use windows authintication without user ans password}
            */
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS01;Database=ASP9_EF;Trusted_Connection=True;TrustServerCertificate=True");
        }

        // DbSet used to create Tables inside my Database
        public DbSet<Employee> Employees { get; set; }
    }
}
