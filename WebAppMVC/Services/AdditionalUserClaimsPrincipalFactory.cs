using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using WebAppMVC.Models;

namespace WebAppMVC.Services;

public class AdditionalUserClaimsPrincipalFactory
    : UserClaimsPrincipalFactory<KoalaCustomer, IdentityRole<int>>
{
    private readonly UserManager<KoalaCustomer> _userManager;
    private readonly IOptions<IdentityOptions> _optionsAccessor;
    private readonly ILogger<AdditionalUserClaimsPrincipalFactory> _logger;

    public AdditionalUserClaimsPrincipalFactory(
        UserManager<KoalaCustomer> userManager,
        RoleManager<IdentityRole<int>> roleManager,
        IOptions<IdentityOptions> optionsAccessor,
        ILogger<AdditionalUserClaimsPrincipalFactory> logger
    )
        : base(userManager, roleManager, optionsAccessor)
    {
        _userManager = userManager;
        _optionsAccessor = optionsAccessor;
        _logger = logger;
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(KoalaCustomer customer)
    {
        var identity = await base.GenerateClaimsAsync(customer);

        var claims = new List<Claim>();

        if (customer.FirstMidName is not null)
        {
            claims.Add(new Claim(ClaimTypes.GivenName, customer.FirstMidName));
        }

        if (customer.LastName is not null)
        {
            claims.Add(new Claim(ClaimTypes.Surname, customer.LastName));
        }

        if (customer.Address is not null)
        {
            claims.Add(new Claim(ClaimTypes.StreetAddress, customer.Address));
        }

        identity.AddClaims(claims);
        // _logger.LogInformation("Claims should been added here {Dump}", identity.Dump());
        return identity;
    }
}
