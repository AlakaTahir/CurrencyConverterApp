using Converter.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Converter.Migrations
{
    public class ConverterInformationDataBaseContext : DbContext
    {
        public ConverterInformationDataBaseContext(DbContextOptions<ConverterInformationDataBaseContext> options) : base(options)
        {
        }

        public DbSet<CurrencyInfo> CurrencyInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CurrencyInfo>().ToTable("CurrencyInfos");
        }
    }
}
