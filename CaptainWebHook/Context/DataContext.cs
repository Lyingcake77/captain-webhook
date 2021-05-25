using CaptainWebHook.Context.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaptainWebHook.Context
{
    public class DataContext : DbContext
    {
        //private static Boolean isInitialized;
        public DataContext(DbContextOptions options) : base(options)
        {
            //if (!isInitialized) { InitializeAzureKeyVaultProvider(); isInitialized = true; }

        }
        public DbSet<Webhook> WebHooks { get; set; }
        public DbSet<SendAttempt> SendAttempts { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
