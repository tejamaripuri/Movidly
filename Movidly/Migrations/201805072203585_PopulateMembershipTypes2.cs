namespace Movidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name='Pay As You Go' WHERE ID=1");
            Sql("UPDATE MembershipTypes SET Name='Quaterly' WHERE ID=2");
            Sql("UPDATE MembershipTypes SET Name='Half Yearly' WHERE ID=3");
            Sql("UPDATE MembershipTypes SET Name='Yearly' WHERE ID=4");
        }
        
        public override void Down()
        {
        }
    }
}
