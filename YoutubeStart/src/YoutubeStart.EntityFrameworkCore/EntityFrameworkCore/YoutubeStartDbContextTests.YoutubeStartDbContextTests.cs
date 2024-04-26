using Microsoft.EntityFrameworkCore;
using Shouldly; // Shouldly kütüphanesini ekleyin
using System;
using System.Linq;
using Volo.Abp.AuditLogging;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Identity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace YoutubeStart.EntityFrameworkCore.Tests
{
    public partial class YoutubeStartDbContextTests
    {
        //[TestFixture]
        public class YoutubeStartDbContextTests
        {
            

            //[TestFixture]
            public class DbSetTests
            {
                //[Test]
                public void ShouldHaveDbSetForUsers()
                {
                    // Arrange
                    var dbContext = DbContextHelper.GetDbContext();

                    // Act & Assert
                    dbContext.Users.ShouldNotBeNull();
                    dbContext.Users.ShouldBeAssignableTo<DbSet<IdentityUser>>();
                }

                //[Test]
                public void ShouldHaveDbSetForRoles()
                {
                    // Arrange
                    var dbContext = DbContextHelper.GetDbContext();

                    // Act & Assert
                    dbContext.Roles.ShouldNotBeNull();
                    dbContext.Roles.ShouldBeAssignableTo<DbSet<IdentityRole>>();
                }
            }

            //[TestFixture]
            public class OnModelCreatingTests
            {
                //[Test]
                public void ShouldConfigureExpectedModules()
                {
                    // Arrange
                    var dbContext = DbContextHelper.GetDbContext();
                    var modelBuilder = new ModelBuilder();

                    // Act
                    dbContext.OnModelCreating(modelBuilder);

                    // Assert

                    // Permission Management
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(PermissionGrant)).ShouldBeTrue();

                    // Setting Management
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(Setting)).ShouldBeTrue();

                    // Background Jobs
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(BackgroundJobRecord)).ShouldBeTrue();

                    // Audit Logging
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(AuditLog)).ShouldBeTrue();

                    // Identity
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(IdentityRole)).ShouldBeTrue();
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(IdentityUser)).ShouldBeTrue();
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(IdentityClaimType)).ShouldBeTrue();
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(OrganizationUnit)).ShouldBeTrue();
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(IdentitySecurityLog)).ShouldBeTrue();
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(IdentityLinkUser)).ShouldBeTrue();
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(IdentityUserDelegation)).ShouldBeTrue();

                    // OpenIddict
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(OpenIddictEntityFrameworkCoreApplication)).ShouldBeTrue();

                    // Feature Management
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(Feature)).ShouldBeTrue();

                    // Tenant Management
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(Tenant)).ShouldBeTrue();
                    modelBuilder.Model.GetEntityTypes().Any(e => e.ClrType == typeof(TenantConnectionString)).ShouldBeTrue();

                    // Add other modules as needed...

                    // Add assertions to ensure that modules are configured as expected
                    // For example:
                    modelBuilder.Model.GetEntityTypes().Count(e => e.ClrType == typeof(PermissionGrant)).ShouldBe(1);
                    modelBuilder.Model.GetEntityTypes().Count(e => e.ClrType == typeof(Setting)).ShouldBe(1);
                    modelBuilder.Model.GetEntityTypes().Count(e => e.ClrType == typeof(BackgroundJobRecord)).ShouldBe(1);
                    modelBuilder.Model.GetEntityTypes().Count(e => e.ClrType == typeof(AuditLog)).ShouldBe(1);
                    // Add similar assertions for other entities...

                    // Check relationships, indices, etc. if needed...
                }

                private class OpenIddictEntityFrameworkCoreApplication
                {
                }
            }
        }
    }
}

