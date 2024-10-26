using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace CycleTogetherMVC.Infrastructure.Identity;

public class SeedAdminAccount
{
    public static async Task SeedAdminUser(IServiceProvider serviceProvider)
    {
        var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    
        var roleExist = await roleManager.RoleExistsAsync("Admin");
        if (!roleExist)
        {
            await roleManager.CreateAsync(new IdentityRole("Admin"));
        }
        
        var adminUser = await userManager.FindByEmailAsync("admin@example.com");
        if (adminUser == null)
        {
            adminUser = new IdentityUser
            {
                UserName = "admin@example.com",
                Email = "admin@example.com"
            };
            await userManager.CreateAsync(adminUser, "Admin@123");
            
            await userManager.AddToRoleAsync(adminUser, "Admin");
        }
    }
}