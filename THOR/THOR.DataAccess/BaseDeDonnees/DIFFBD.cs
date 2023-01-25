using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using static System.Net.Mime.MediaTypeNames;

namespace THOR.DataAccess.BaseDeDonnees
{
	public class DIFFBD : DbContext
	{
        public DIFFBD()
        {
        }
        public DIFFBD (DbContextOptions<DIFFBD> options):base(options)
		{
			
		}


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            IConfigurationRoot _configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();

            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server = 127.0.0.1, 1433; Database = test; user id = sa; password = MyPass@word; TrustServerCertificate = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
    }
}

