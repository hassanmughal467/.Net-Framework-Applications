using Microsoft.EntityFrameworkCore;
using TrackingAPI.models;

namespace TrackingAPI.Data
{
    //IssueDbcontext inherit with DbContext for interacting
    public class IssueDbcontext : DbContext
    {
        //WeakReference use dboptions this allow setting up options needed by dbcontext like connectionstring
        public IssueDbcontext(DbContextOptions<IssueDbcontext> options) : base(options)
        {


        }
        //DbSet is UseExtensions to representation of data in database.It will allow us to maniuplate data from a table issue
        public DbSet<Issue> Issue
            { get; set; } 

        //after db context is WeakReference have to register it with dependency injections container this way we can request an instance in the controller
            
    }
}
