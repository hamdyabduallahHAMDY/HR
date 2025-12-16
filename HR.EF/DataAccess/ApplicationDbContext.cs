using Logger;
using Microsoft.EntityFrameworkCore;
using HR.Core.Models;


namespace HR.EF.DataAccess;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        try
        {
            //Database.EnsureCreated();
        }
        catch (Exception ex)
        {
            if (ex.Message.ToLower().Contains("a network-related or instance-specific error occurred while establishing a connection to sql server"))
            {
                Logs.Log("???? ????? ?? ??????? ?????? ????????");
            }
            else
                Logs.Log("\t\t???? ????? ?? ??????? ?????? ????????\n\n" + ex.Message);
        }
    }
    #region
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<EmploymentContract> EmploymentContracts { get; set; }
    public DbSet<GroupRol> GroupRols { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<LeaveBalance> leaveBalances { get; set; }
    public DbSet<LeaveRequest> leaveRequests { get; set; }
    public DbSet<User> Users { get; set; }






    #endregion
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
    public void InitializeDatabase()
    {
        // Check if the database exists
        if (!Database.CanConnect())
        {
            try
            {
                // Create the database and all tables
                Database.EnsureCreated();

            }
            catch (Exception ex)
            {

                //  Logs.Log($"Error creating database: {ex.Message}");
            }
        }
    }


}

