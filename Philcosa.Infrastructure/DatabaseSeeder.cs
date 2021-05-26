using Philcosa.Application.Helpers;
using Philcosa.Application.Interfaces.Services;
using Philcosa.Application.Models.Identity;
using Philcosa.Infrastructure.Contexts;
using Philcosa.Shared.Constants.Permission;
using Philcosa.Shared.Constants.Role;
using Philcosa.Shared.Constants.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using System.IO;
using Philcosa.Domain.Entities;
using System.Collections.Generic;
using CsvHelper;
using System.Globalization;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Philcosa.Infrastructure
{
    public class DatabaseSeeder : IDatabaseSeeder
    {
        private readonly ILogger<DatabaseSeeder> _logger;
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DatabaseSeeder(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext db, ILogger<DatabaseSeeder> logger)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            _logger = logger;
        }

        public void Initialize()
        {
            AddCustomerPermissionClaims();
            AddAdministrator();
            AddBasicUser();
            AddDefaultCovers();
            _db.SaveChanges();
        }

        private void AddCustomerPermissionClaims()
        {
            Task.Run(async () =>
            {
                var adminRoleInDb = await _roleManager.FindByNameAsync(RoleConstants.AdministratorRole);
                if (adminRoleInDb != null)
                {
                    await _roleManager.AddCustomPermissionClaim(adminRoleInDb, "Permissions.Communication.Chat");
                }
            }).GetAwaiter().GetResult();
        }

        private void AddAdministrator()
        {
            Task.Run(async () =>
            {
                //Check if Role Exists
                var adminRole = new IdentityRole(RoleConstants.AdministratorRole);
                var adminRoleInDb = await _roleManager.FindByNameAsync(RoleConstants.AdministratorRole);
                if (adminRoleInDb == null)
                {
                    await _roleManager.CreateAsync(adminRole);
                    _logger.LogInformation("Seeded Administrator Role.");
                }
                //Check if User Exists
                var superUser = new ApplicationUser
                {
                    FirstName = "Mukesh",
                    LastName = "Murugan",
                    Email = "mukesh@blazorhero.com",
                    UserName = "mukesh",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    CreatedOn = DateTime.Now,
                    IsActive = true
                };
                var superUserInDb = await _userManager.FindByEmailAsync(superUser.Email);
                if (superUserInDb == null)
                {
                    await _userManager.CreateAsync(superUser, UserConstants.DefaultPassword);
                    var result = await _userManager.AddToRoleAsync(superUser, RoleConstants.AdministratorRole);
                    if (result.Succeeded)
                    {
                        await _roleManager.GeneratePermissionClaimByModule(adminRole, PermissionModules.Users);
                        await _roleManager.GeneratePermissionClaimByModule(adminRole, PermissionModules.Roles);
                        await _roleManager.GeneratePermissionClaimByModule(adminRole, PermissionModules.Products);
                        await _roleManager.GeneratePermissionClaimByModule(adminRole, PermissionModules.Brands);
                    }
                    _logger.LogInformation("Seeded User with Administrator Role.");
                }
            }).GetAwaiter().GetResult();
        }

        private void AddBasicUser()
        {
            Task.Run(async () =>
            {
                //Check if Role Exists
                var basicRole = new IdentityRole(RoleConstants.BasicRole);
                var basicRoleInDb = await _roleManager.FindByNameAsync(RoleConstants.BasicRole);
                if (basicRoleInDb == null)
                {
                    await _roleManager.CreateAsync(basicRole);
                    _logger.LogInformation("Seeded Basic Role.");
                }
                //Check if User Exists
                var basicUser = new ApplicationUser
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john@blazorhero.com",
                    UserName = "johndoe",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    CreatedOn = DateTime.Now,
                    IsActive = true
                };
                var basicUserInDb = await _userManager.FindByEmailAsync(basicUser.Email);
                if (basicUserInDb == null)
                {
                    await _userManager.CreateAsync(basicUser, UserConstants.DefaultPassword);
                    await _userManager.AddToRoleAsync(basicUser, RoleConstants.BasicRole);
                    _logger.LogInformation("Seeded User with Basic Role.");
                }
            }).GetAwaiter().GetResult();
        }

        private void AddDefaultCovers()
        {
            if (!_db.Covers.Any())
            {
                Task.Run(async () =>
                {
                    var countries = await _db.Countries.ToListAsync();
                    var issuedByEntities = await _db.IssuedByEntities.ToListAsync();
                    var themes = await _db.Themes.ToListAsync();
                    var types = await _db.CoverTypes.ToListAsync();
                    var values = await _db.CoverValues.ToListAsync();

                    string seedFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\Philcosa.Infrastructure\\Seeds\\";
                    List<Cover> covers = GetCovers(seedFolder, countries, issuedByEntities, themes, types, values);

                    foreach (var cover in covers)
                    {
                        try
                        {
                            if (_db.Covers.Any(c => c.Id == cover.Id))
                                continue;

                            foreach (var coverTheme in cover.CoverThemes)
                            {

                                await _db.AddAsync(coverTheme);
                            }

                            await _db.AddAsync(cover);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }).GetAwaiter().GetResult();

            }
        }

        private static List<Cover> GetCovers(string seedFolder, List<Country> countries, List<IssuedByEntity> issuedByEntities, List<Theme> themes,
      List<CoverType> types, List<CoverValue> values)
        {
            string file = Path.Combine(seedFolder, "Covers.csv");

            var records = new List<Cover>();
            using (var rd = new StreamReader(file))
            {
                using var csv = new CsvReader(rd, CultureInfo.InvariantCulture);
                csv.Read();
                csv.ReadHeader();
                var id = 1;
                while (csv.Read())
                {

                    var dateWithId = csv.GetField<string>("Date");
                    var dates = dateWithId.Split(".");
                    var date = DateTime.ParseExact(dates[0], "yyyyMMdd", CultureInfo.InvariantCulture);
                    var numberOnDate = dates[1];

                    var themesList = new List<Theme>();
                    var theme1 = csv.GetField<string>("Theme A");
                    if (!string.IsNullOrEmpty(theme1))
                        themesList.Add(themes.SingleOrDefault(x => x.Name == theme1));

                    var theme2 = csv.GetField<string>("Theme B");
                    if (!string.IsNullOrEmpty(theme2))
                        themesList.Add(themes.SingleOrDefault(x => x.Name == theme2));

                    var theme3 = csv.GetField<string>("Theme C");
                    if (!string.IsNullOrEmpty(theme3))
                        themesList.Add(themes.SingleOrDefault(x => x.Name == theme3));

                    var theme4 = csv.GetField<string>("Theme D");
                    if (!string.IsNullOrEmpty(theme4))
                        themesList.Add(themes.SingleOrDefault(x => x.Name == theme4));

                    var areaFromCSV = csv.GetField<string>("Area");
                    var typeFromCSV = csv.GetField<string>("Type");
                    var issuedByFromCSV = csv.GetField<string>("Issued By");
                    var noFromCSV = csv.GetField<string>("No");
                    var valueFromCSV = csv.GetField<string>("Value");
                    var descFromCSV = csv.GetField<string>("Description");
                    var noIssuedFromCSV = csv.GetField<string>("# Issued").Trim();
                    var atlasFromCSV = csv.GetField<string>("Atlas");
                    var albertaFromCSV = csv.GetField<string>("Alberta");

                    Int32.TryParse(noIssuedFromCSV, out int j);
                    var coverThemeList = new List<CoverTheme>();
                    foreach (var themeForCover in themesList)
                    {
                        var coverTheme = new CoverTheme
                        {
                            CoverId = id,
                            ThemeId = themeForCover.Id
                        };
                        coverThemeList.Add(coverTheme);
                    }
                    var cover = new Cover
                    {
                        Id = id,
                        CreatedBy = "DataSeed",
                        CreatedOn = DateTime.Now,
                        LastModifiedBy = null,
                        LastModifiedOn = null,

                        CoverDate = date,
                        IdOnDate = numberOnDate,
                        IssuedBy = issuedByEntities.SingleOrDefault(x => x.Code == issuedByFromCSV),
                        Number = noFromCSV ?? null,
                        Description = descFromCSV ?? null,
                        AmountIssued = noIssuedFromCSV,
                        Atlas = atlasFromCSV ?? null,
                        Alberta = albertaFromCSV ?? null,
                        CoverType = types.SingleOrDefault(x => x.Code == typeFromCSV),
                        Value = values.SingleOrDefault(x => x.Code == valueFromCSV),
                        Country = countries.SingleOrDefault(x => x.Code == areaFromCSV),
                        CoverThemes = coverThemeList

                    };
                    records.Add(cover);
                    id++;
                }
                return records;
            }
        }
    }
}