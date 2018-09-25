
using Microsoft.EntityFrameworkCore;
using MySql.Data.Entity;
using System;


public class TrackerContext : Microsoft.EntityFrameworkCore.DbContext
{
    public TrackerContext(DbContextOptions<TrackerContext> options) : base(options) { }
    public DbSet<TrackerContext> trackerDb { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string hostname, dbname, username, password;
        hostname = "vtpro.cdawfdfnvlmb.us-east-2.rds.amazonaws.com";
        dbname = "MyDB";
        username = "davidrowan07";
        password = "sinister2!";
        optionsBuilder.UseSqlServer("Data Source=" + hostname + ";Initial Catalog=" + dbname + ";User ID=" + username + ";Password=" + password + ";");
    }

}
