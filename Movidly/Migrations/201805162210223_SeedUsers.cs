namespace Movidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'00f450a1-7531-435d-ac9d-621131746ee8', N'admin@movidly.com', 0, N'ADJljPekCSwGXh2qYpP8S/JEBUXmJ4hrrDu37QLVh4Eg4p3U0MR4wAISRSacH6CDlQ==', N'fa116242-3244-492b-8440-ebe8e7cc7d55', NULL, 0, 0, NULL, 1, 0, N'admin@movidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5e5dfe7d-7752-4645-a0d0-510a4b0c0ea4', N'guest@movidly.com', 0, N'AFqM2r4nURKhXmQfs/wtsuveYYq5WM1G2225MBjX0m/HC6mTM772XQwlU51xZtm0dw==', N'11dc066c-ec35-456a-bb84-2268608cfff1', NULL, 0, 0, NULL, 1, 0, N'guest@movidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd4277a5e-e871-482a-b876-60837319e59e', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'00f450a1-7531-435d-ac9d-621131746ee8', N'd4277a5e-e871-482a-b876-60837319e59e')
");
        }
        
        public override void Down()
        {
        }
    }
}
