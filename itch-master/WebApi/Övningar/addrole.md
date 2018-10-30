# L�gg till en roll

Startvy:

![](addrole-form.PNG)

Epost matas in p� k�nd anv�ndare + en valfri roll s�tts:

![](addrole-input.PNG)

N�r OK trycks s� l�gg till rollen till anv�ndaren:

![](addrole-success.PNG)

## Felhantering

Validera formul�ret:

![](addrole-validation.PNG)

Rapportera om det inte finns anv�ndare med denna epost:

![](addrole-dontexist.PNG)

Rapportera om anv�ndaren redan har denna roll:

![](addrole-error-alreadybelongs.PNG)

## Beh�righeter

L�gg in dessa roller f�r anv�ndarna:

    lise@lotte.se tillh�r rollen CategoryAdmin
    dennis@bonde.se har ingen roll
    superadmin@gmail.com tillh�r rollen SuperAdmin

CategoryAdmin's kan administrera kategorier

SuperAdmin's kan administrera kategorier + administera roller (i Admin-fliken)


## Tips - injection

L�gg in detta i controllern f�r att f� tillg�ng till UserManager och RoleManager

    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

I Startup.cs:

    services.AddIdentity<IdentityUser, IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddDefaultUI()
        .AddDefaultTokenProviders();

## Tips

Kolla upp dessa metoder:

    await _userManager.FindByEmailAsync
    await _userManager.IsInRoleAsync
    await _userManager.IsInRoleAsync
    await _roleManager.CreateAsync

    ModelState

    ModelState.AddModelError

    Exceptions o try-catch
