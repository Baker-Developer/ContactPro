using ContactPro.Data;
using Microsoft.EntityFrameworkCore;
namespace ContactPro.Helpers
{
    public static class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider serviceProvider)
        {
            // Get an instance of the db application context
            var dbContextServiceProvider = serviceProvider.GetRequiredService<ApplicationDbContext>();

            // Migration: This is equivalent to update-database
            await dbContextServiceProvider.Database.MigrateAsync();
        }
    }
}
