using Microsoft.AspNetCore.Identity;
using SimpleBase;
using WebAppMVC.Models;

namespace WebAppMVC.Data;

public class DataGenerators
{
    private static readonly string passwordHash =
        new PasswordHasher<KoalaCustomer>().HashPassword(null, "secret");
    private static byte[] bytes = new byte[32];
    
    private static int idPool = 1;

    internal static KoalaCustomer NewCustomer(string email, string firstMidName, string lastName)
    { 
        Random.Shared.NextBytes(bytes);
        var customer = new KoalaCustomer()
        {
            Id = idPool++,
            UserName = email,
            FirstMidName = firstMidName,
            LastName = lastName,
            NormalizedUserName = email.ToUpper(),
            Email = email,
            NormalizedEmail = email.ToUpper(),
            EmailConfirmed = true,
            PasswordHash = passwordHash,
            SecurityStamp = Base32.Rfc4648.Encode(bytes),
            PhoneNumber = null,
            PhoneNumberConfirmed = false,
            TwoFactorEnabled = false,
            LockoutEnd = null,
            LockoutEnabled = true,
            AccessFailedCount = 0,
            RegisteredAt = DateTime.Now,
            LastLogin = DateTime.Today
        };

        return customer;
    }
}