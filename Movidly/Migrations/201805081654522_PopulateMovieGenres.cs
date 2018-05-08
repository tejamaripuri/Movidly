namespace Movidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES VALUES (1, 'Comedy')");
            Sql("INSERT INTO GENRES VALUES (2, 'Action')");
            Sql("INSERT INTO GENRES VALUES (3, 'Family')");
            Sql("INSERT INTO GENRES VALUES (4, 'Romance')");
        }
        
        public override void Down()
        {
        }
    }
}
